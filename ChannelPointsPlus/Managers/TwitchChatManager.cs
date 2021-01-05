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

namespace ChannelPointsPlus
{
    public class TwitchChatManager
    {
        private frmMain _mainForm;
        private TwitchClient client;
        private string _username;

        public TwitchChatManager(frmMain mainForm, string username, string OAuth)
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

            client.OnMessageReceived += Client_OnMessageReceived;
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

        private async void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            
            if (_mainForm.ttsSubscribersOnly)
            {               
                if (e.ChatMessage.IsSubscriber)
                {
                    if (_mainForm.speechChat.isTurnedOn) _mainForm.speechChat.ReadMessage(e.ChatMessage.Message);
                }
            }
            else
            {
                if (_mainForm.speechChat.isTurnedOn) _mainForm.speechChat.ReadMessage(e.ChatMessage.Message);
            }

            _mainForm.ChatMessageLog($"{ e.ChatMessage.Username}: {e.ChatMessage.Message}");
        }
    }
}
