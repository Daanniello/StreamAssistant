using ChannelPointsPlus.APIs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPointsPlus.Managers
{
    public class RandomPickerManager
    {
        private TwitchApi twitchApi;
        private List<RandomPickerViewer> joinedViewers = new List<RandomPickerViewer>();
        private frmMain mainForm;
        private decimal timeLeft;
        bool isInProcess = false;

        private string requirement;

        public RandomPickerManager(frmMain mainForm, TwitchApi twitchApi)
        {
            this.mainForm = mainForm;
            this.twitchApi = twitchApi;
        }

        public async void Start(decimal duration, bool allViewers, string requirement = null)
        {
            this.requirement = requirement;
            if (requirement == null || requirement == "")
            {
                if (allViewers) twitchApi.SendMessageInChannel($"Random picker started. Everyone can be chosen");
                else twitchApi.SendMessageInChannel($"Random picker started. Talk in chat to enter.");
            }
            else
            {
                if (requirement.Contains("*")) twitchApi.SendMessageInChannel($"Random picker started. Type '{requirement}', with your personal input instead of the wildcard(*) to enter.");
                else twitchApi.SendMessageInChannel($"Random picker started. Type '{requirement}' to enter.");

            }

            timeLeft = duration;
            isInProcess = true;

            //Adds a temperary OnMessageListener
            if (!allViewers)
            {
                twitchApi.client.OnMessageReceived += Client_OnMessageReceived;
            }
            else
            {
                var viewers = await twitchApi.GetAllViewers();
                foreach (var viewer in viewers)
                {
                    joinedViewers.Add(new RandomPickerViewer(null, viewer, ""));
                }
            }
            var endTime = DateTime.Now;
            endTime = endTime.AddSeconds(Convert.ToDouble(duration));
            do
            {
                mainForm.updateRandomPickerTimer("Time Left: " + timeLeft.ToString());
                timeLeft -= 1;
                await Task.Delay(1000);
            } while (DateTime.Now < endTime && isInProcess);

            if (isInProcess == true) End();
            isInProcess = false;
        }

        public async void End()
        {


            isInProcess = false;
            mainForm.updateRandomPickerTimer("Time left: Ended");
            //Deletes the OnMessageListener again
            twitchApi.client.OnMessageReceived -= Client_OnMessageReceived;

            //Go through all messages 
            if (joinedViewers.Count == 0)
            {
                twitchApi.SendMessageInChannel($"Random picker ended. No winner");
                mainForm.updateRandomPickerWinner("No results", ":c");
                return;
            }
            var randomNumber = new Random().Next(0, joinedViewers.Count - 1);
            var winner = joinedViewers[randomNumber];

            mainForm.updateRandomPickerWinner(winner.username, winner.message);
            twitchApi.SendMessageInChannel($"Random picker ended. The winner is {winner.username}");

            var message = await RequestBeatSaberMapFromDescription(winner.message);
            twitchApi.SendMessageInChannel(message);
        }

        private async Task<string> RequestBeatSaberMapFromDescription(string description)
        {
            try
            {
                var scoresaberId = description.Replace("&sort=2", "").Split('/').Last();

                using (var client = new HttpClient())
                {
                    var recentSongDataRaw = await client.GetStringAsync($"https://new.scoresaber.com/api/player/{scoresaberId}/scores/recent/1");
                    var result = JsonConvert.DeserializeObject(recentSongDataRaw);
                    var scores = JObject.Parse(result.ToString())["scores"].First();
                    var songHash = scores["songHash"].ToString();

                    var request = new HttpRequestMessage()
                    {
                        RequestUri = new Uri($"https://beatsaver.com/api/maps/by-hash/{songHash}"),
                        Method = HttpMethod.Get,
                    };

                    var productValue = new ProductInfoHeaderValue("ScraperBot", "1.0");
                    var commentValue = new ProductInfoHeaderValue("(+http://www.example.com/ScraperBot.html)");

                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("*/*"));
                    client.DefaultRequestHeaders.UserAgent.Add(productValue);
                    client.DefaultRequestHeaders.UserAgent.Add(commentValue);

                    var httpResponseMessage2 = await client.SendAsync(request);                    
                    var recentSongsJsonDataBeatSaver = await httpResponseMessage2.Content.ReadAsStringAsync();
                    var recentSongsInfoBeatSaver = JsonConvert.DeserializeObject(recentSongsJsonDataBeatSaver);
                    var bsrCode = JObject.Parse(recentSongsInfoBeatSaver.ToString())["key"].ToString();

                    return $"!bsr {bsrCode}";
                }
            }
            catch (Exception ex)
            {
                return $"Could not request the map automatically :c";
            }

        }

        private async void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            if (requirement == null) return;
            string[] requirements = new string[] { requirement };
            if (requirement.Contains("*")) requirements = requirement.Split('*');


            var isAllowed = true;
            foreach (var req in requirements)
            {
                if (!e.ChatMessage.Message.Contains(req)) isAllowed = false;
            }
            if (isAllowed)
            {
                if (joinedViewers.Where(x => x.userId == e.ChatMessage.UserId).Count() == 0) joinedViewers.Add(new RandomPickerViewer(e.ChatMessage.UserId, e.ChatMessage.Username, e.ChatMessage.Message));
            }
        }

        private class RandomPickerViewer
        {
            public string userId;
            public string username;
            public string message;

            public RandomPickerViewer(string userId, string username, string message)
            {
                this.userId = userId;
                this.username = username;
                this.message = message;
            }
        }
    }
}
