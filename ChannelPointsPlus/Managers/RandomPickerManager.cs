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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

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

        public async void Start(decimal duration, bool allViewers, bool AutomaticMapRequest, string requirement = null)
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
                mainForm.UpdateCompetitorsList(joinedViewers);
            }
            var endTime = DateTime.Now;
            endTime = endTime.AddSeconds(Convert.ToDouble(duration));
            do
            {
                mainForm.updateRandomPickerTimer("Time Left: " + timeLeft.ToString());
                timeLeft -= 1;
                await Task.Delay(1000);
            } while (DateTime.Now < endTime && isInProcess);

            if (isInProcess == true) End(AutomaticMapRequest);
            isInProcess = false;
        }

        public async void End(bool AutomaticMapRequest)
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

            //Beat Saber feature to request a map directly after by Scoresaber ID
            if (AutomaticMapRequest)
            {
                var message = await RequestBeatSaberMapFromDescription(winner.message);
                twitchApi.SendMessageInChannel(message);
            }
        }

        private async Task<string> RequestBeatSaberMapFromDescription(string description)
        {
            try
            {
                var scoresaberId = Regex.Replace(description.Replace("&sort=2", "").Split('/').Last(), "[^0-9.]", "");


                var scores = await ScoreSaberApi.GetRecentSongDataAsync(scoresaberId);

                var songHash = scores["songHash"].ToString();
                var difficulty = scores["difficultyRaw"].ToString();
                var mods = scores["mods"].ToString();

                var songInfo = await BeatSaverApi.GetSongByHash(songHash);
                var bsrCode = songInfo["id"].ToString();

                mainForm.AddRandomPickerWinnerDescription($"Difficulty: {difficulty}\nMods: {mods}");

                return $"!modadd {bsrCode}";

            }
            catch (Exception ex)
            {
                return $"Could not request the map automatically :c";
            }

        }

        public async void RequestRandomBeatMap()
        {
            //Gets the latest song from beatsaver and get the key out of that
            var latestSongInfo = await BeatSaverApi.GetMostRecentSongInfo();
            var key = latestSongInfo["id"].ToString();
            //Converts the hex key to a real number 
            var mapAmount = Convert.ToInt32(key, 16);
            //Generates a new random hex key that is between the amount of maps available
            //Also retries max 10 times and checks if the key matches a real map
            var randomGenerator = new Random();
            var randomKey = "";
            var retryAmount = 0;
            do
            {
                var randomMapNumber = randomGenerator.Next(0, mapAmount);
                randomKey = string.Format("{0:x}", randomMapNumber);
            } while (await BeatSaverApi.GetSongByKey(randomKey) == null && retryAmount++ < 10);

            //Requests the bsr key into twitch chat 
            twitchApi.SendMessageInChannel($"!modadd {randomKey}");
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
                mainForm.UpdateCompetitorsList(joinedViewers);
            }


        }

        public class RandomPickerViewer
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
