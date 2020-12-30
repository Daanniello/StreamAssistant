using System;
using System.IO;
using TwitchLib.PubSub;
using TwitchLib.PubSub.Events;

namespace ChannelPointsPlus
{
    class TwitchPointsRewardsManager
    {
        private static TwitchPubSub client;
        private static frmMain _mainForm;

        public TwitchPointsRewardsManager(frmMain mainForm)
        {
            _mainForm = mainForm; 
            client = new TwitchPubSub();

            client.OnPubSubServiceConnected += onPubSubServiceConnected;
            client.OnListenResponse += onListenResponse;
            client.OnRewardRedeemed += OnRewardRedeemed;


            if (File.Exists("resetid.txt")) { Properties.Settings.Default.savedChannelID = ""; File.Delete("resetid.txt"); }
            if (Properties.Settings.Default.savedChannelID == "")
            {
                Properties.Settings.Default.savedChannelID = Prompt.ShowDialog("Please enter your Twitch ChannelID. (THIS IS NOT YOUR USERNAME)", "Enter Channel ID");
                if (Properties.Settings.Default.savedChannelID == "") { mainForm.Close(); return; }
                Properties.Settings.Default.Save();
            }
            client.ListenToRewards(Properties.Settings.Default.savedChannelID);

            client.Connect();
        }

        private static void onPubSubServiceConnected(object sender, EventArgs e)
        {
            _mainForm.Log($"Connected with {Properties.Settings.Default.savedChannelID}");
            client.SendTopics();
            
        }

        private static void onListenResponse(object sender, OnListenResponseArgs e)
        {
            if (!e.Successful)
                throw new Exception($"Failed to listen! Response: {e.Response}");
        }

        private async void OnRewardRedeemed(object sender, OnRewardRedeemedArgs e)
        {
            _mainForm.Log($"Reward claimed: {e.DisplayName} used {e.RewardTitle}");
            if (_mainForm.bindingsAudio.ContainsKey(e.RewardTitle) && e.Status != "ACTION_TAKEN")
            {
                _mainForm.bindingsAudio.TryGetValue(e.RewardTitle, out string output);
                _mainForm.audioPlayer.PlaySound(output);
            }

            if (_mainForm.bindingsScene.ContainsKey(e.RewardTitle) && e.Status != "ACTION_TAKEN")
            {
                _mainForm.bindingsScene.TryGetValue(e.RewardTitle, out string output);
                _mainForm.sceneChanger.ChangeScene(output, _mainForm.GetSceneDuration());
            }

            if (_mainForm.bindingsSceneSource.ContainsKey(e.RewardTitle) && e.Status != "ACTION_TAKEN")
            {
                _mainForm.bindingsSceneSource.TryGetValue(e.RewardTitle, out string output);
                _mainForm.sceneSourceChanger.ChangeSceneSource(output, _mainForm.GetSceneSourceDuration());
            }
        }
    }
}
