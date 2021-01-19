using ChannelPointsPlus.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
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
                //TODO ADD ALL VIEWERS TO THE JOINEDVIEWERS LIST 
                var viewers = await twitchApi.GetAllViewers();
                foreach(var viewer in viewers)
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

            if(isInProcess == true) End();
            isInProcess = false;
        }

        public void End()
        {
           

            isInProcess = false;
            mainForm.updateRandomPickerTimer("Time left: Ended");
            //Deletes the OnMessageListener again
            twitchApi.client.OnMessageReceived -= Client_OnMessageReceived;  

            //Go through all messages 
            if(joinedViewers.Count == 0)
            {
                twitchApi.SendMessageInChannel($"Random picker ended. No winner");
                mainForm.updateRandomPickerWinner("No results", ":c");
                return;
            }
            var randomNumber = new Random().Next(0, joinedViewers.Count - 1);
            var winner = joinedViewers[randomNumber];

            mainForm.updateRandomPickerWinner(winner.username, winner.message);
            twitchApi.SendMessageInChannel($"Random picker ended. The winner is {winner.username}");
        }

        private async void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            if (requirement == null) return;
            string[] requirements = new string[] { requirement };
            if (requirement.Contains("*")) requirements = requirement.Split('*');


            var isAllowed = true;
            foreach(var req in requirements)
            {
                if (!e.ChatMessage.Message.Contains(req)) isAllowed = false;
            }
            if (isAllowed)
            {
                if(joinedViewers.Where(x => x.userId == e.ChatMessage.UserId).Count() == 0) joinedViewers.Add(new RandomPickerViewer(e.ChatMessage.UserId, e.ChatMessage.Username, e.ChatMessage.Message));
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
