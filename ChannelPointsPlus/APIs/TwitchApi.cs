using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace ChannelPointsPlus.APIs
{
    public class TwitchApi
    {
        private frmMain _mainForm;
        public TwitchClient client;
        public string _username;

        public TwitchApi(frmMain mainForm, string username, string OAuth)
        {
            _mainForm = mainForm;
            _username = username;

            ConnectionCredentials credentials = new ConnectionCredentials(username, OAuth);
            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };
            WebSocketClient customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);
            client.Initialize(credentials, username);
            
            client.OnConnected += Client_OnConnected;
            client.OnDisconnected += Client_OnDisconnected;
           
            client.Connect();
        }

        private void Client_OnDisconnected(object sender, TwitchLib.Communication.Events.OnDisconnectedEventArgs e)
        {
            _mainForm.ChatMessageLog($"Disconnected...");
        }

        private void Client_OnConnected(object sender, TwitchLib.Client.Events.OnConnectedArgs e)
        {
            _mainForm.ChatMessageLog($"Connected with user: {e.BotUsername}");
        }

        public async Task<List<string>> GetAllViewers() //https://tmi.twitch.tv/group/user/silverhazei/chatters
        {
            var viewers = new List<string>();
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync($"https://tmi.twitch.tv/group/user/{_username}/chatters");
                response.EnsureSuccessStatusCode();
                dynamic results = JsonConvert.DeserializeObject<object>(await response.Content.ReadAsStringAsync());
                var t = results.chatters.viewers.ToString().Replace("\r\n  \"", "").Replace("\"", "").Replace("\r\n]", "").Replace("[", "");
                var ar = t.Split(',');
                viewers.AddRange(ar);
            }
            return viewers;
        }

        public void SendMessageInChannel(string message)
        {
            if (client.JoinedChannels.First().Channel == _username) client.SendMessage(client.JoinedChannels.First(), message);
        }
    }
}
