using SLOBSharp.Client;
using SLOBSharp.Client.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChannelPointsPlus
{
    public partial class frmMain : Form
    {
        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        public Dictionary<string, string> bindingsAudio = new Dictionary<string, string>();
        public Dictionary<string, string> bindingsScene = new Dictionary<string, string>();
        public Dictionary<string, string> bindingsVideo = new Dictionary<string, string>();
        public Dictionary<string, string> bindingsSceneSource = new Dictionary<string, string>();
        private int volumeLevel, savedVolumeLevel;
        private int boxSelectionAudio = 0;
        private int boxSelectionScene = 0;
        private int boxSelectionVideo = 0;
        private int boxSelectionSceneSource = 0;
        public SceneChanger sceneChanger;
        public SceneSourceChanger sceneSourceChanger;
        public AudioPlayer audioPlayer;
        public SlobsPipeClient slobsClient;
        public SpeechChat speechChat;
        public VideoPlayer videoPlayer;

        public bool ttsSubscribersOnly = false;

        private bool TTSSettingsTabOpen = false;

        public frmMain()
        {
            InitializeComponent();          
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            new ProgramStartUp();

            slobsClient = new SlobsPipeClient("slobs");

            videoPlayer = new VideoPlayer(this);
            audioPlayer = new AudioPlayer(this);
            sceneChanger = new SceneChanger(this);
            sceneSourceChanger = new SceneSourceChanger(this);
            new TwitchPointsRewardsManager(this);

            //Checks if the user already has twitch info
            if (File.Exists("settingsTwitch.txt"))
            {
                String[] loadSettings = File.ReadAllLines("settingsTwitch.txt");
                for(var x = 0; x < 1; x++)
                {
                    string[] split = loadSettings[x].Split('|');
                    ConnectTwitchChat(split[0], split[1]);
                }                
            }

            volumeLevel = savedVolumeLevel = Convert.ToInt32(Properties.Settings.Default.savedVolumeLevel);
            reloadAudioListItems();
            reloadSceneListItems();
            reloadSceneSourceListItems();
            reloadVideoListItems();

            txtVolume.Text = volumeLevel.ToString();
            trkVolume.Value = volumeLevel;

            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayIcon.Icon = this.Icon;

        }

        //For testing the streamlabs api
        private async void test()
        {
            var slobsCurrentSceneRequest = SlobsRequestBuilder.NewRequest().SetMethod("getModel").SetResource("PerformanceService").BuildRequest();
            var slobsCurrentSceneRpcResponse = await slobsClient.ExecuteRequestAsync(slobsCurrentSceneRequest).ConfigureAwait(false);
            var currentScene = slobsCurrentSceneRpcResponse.Result.FirstOrDefault();
        }

        //Let the form be draggable
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        public void Log(string logMessage)
        {
            this.Invoke(new MethodInvoker(() => LogTextBox.AppendText(logMessage + "\n")));
            //TODO Add Log to a log file
        }

        public void ChatMessageLog(string logMessage)
        {
            this.Invoke(new MethodInvoker(() => ChatTextBox.AppendText(logMessage + "\n")));
            //TODO Add Log to a log file
        }

        private void frmMain_OnClosing(object sender, FormClosingEventArgs e)
        {
            trayIcon.Visible = false;            
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, uint Msg);

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            ShowWindow(this.Handle, 0x09);
        }

        public int GetSceneDuration()
        {
            return Convert.ToInt32(SceneChangeDuration.Value);
        }

        public int GetSceneSourceDuration()
        {
            return Convert.ToInt32(SceneSourceChangeDuration.Value);
        }

        public int GetAudioVolumeLevel()
        {
            return volumeLevel;
        }

        public void SetStopAllPlayersButton(bool enabled)
        {
            btnStopAll.Enabled = enabled;
        }

        /// <summary>
        /// Updates the volume level as a user moves the trackbar.
        /// </summary>
        private void trkVolume_Scroll(object sender, EventArgs e)
        {
            this.volumeLevel = trkVolume.Value;
            txtVolume.Text = this.volumeLevel.ToString();
        }

        /// <summary>
        /// Saves the current volume level once the user unclicks the Trackbar.
        /// </summary>
        private void TrkVolume_MouseUp(object sender, MouseEventArgs e)
        {
            if (savedVolumeLevel != volumeLevel)
            {
                Properties.Settings.Default.savedVolumeLevel = volumeLevel.ToString();
                Properties.Settings.Default.Save();
                savedVolumeLevel = Convert.ToInt32(Properties.Settings.Default.savedVolumeLevel);
            }
        }

        /// <summary>
        /// Reloads the bindings array into the ListBoxes and saves the bindings to file if nessecary.
        /// </summary>
        private void reloadAudioListItems()
        {
            lstbxSoundsRewards.Items.Clear();
            lstbxSoundsPaths.Items.Clear();

            foreach (KeyValuePair<string, string> kvp in bindingsAudio)
            {
                lstbxSoundsRewards.Items.Add(kvp.Key);
                string[] val = kvp.Value.Split('\\');
                lstbxSoundsPaths.Items.Add(val[val.Length - 1]);
            }

            if (boxSelectionAudio > (bindingsAudio.Count - 1)) boxSelectionAudio = (bindingsAudio.Count - 1);

            if (bindingsAudio.Count == 0)
            {
                btnRemove.Enabled = false;
                btnTest.Enabled = false;
                btnEditSound.Enabled = false;
                btnEditTitle.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
                btnTest.Enabled = true;
                btnEditSound.Enabled = true;
                btnEditTitle.Enabled = true;
                lstbxSoundsRewards.SelectedIndex = boxSelectionAudio;
                lstbxSoundsPaths.SelectedIndex = boxSelectionAudio;
          
            }
            saveBindingsAudio();
        }

        private void reloadSceneSourceListItems()
        {
            SceneSourceRewards.Items.Clear();
            SceneSourceNames.Items.Clear();

            foreach (KeyValuePair<string, string> kvp in bindingsSceneSource)
            {
                SceneSourceRewards.Items.Add(kvp.Key);
                string[] val = kvp.Value.Split('\\');
                SceneSourceNames.Items.Add(val[val.Length - 1]);
            }

            if (boxSelectionSceneSource > (bindingsSceneSource.Count - 1)) boxSelectionSceneSource = (bindingsSceneSource.Count - 1);

            if (bindingsSceneSource.Count == 0)
            {
                //TODO: Set scene add reactions to false 
            }
            else
            {
                //TODO: Set scene add reactions to true
                SceneSourceRewards.SelectedIndex = boxSelectionAudio;
                SceneSourceNames.SelectedIndex = boxSelectionAudio;                
            }
            saveBindingsSceneSource();
        }

        private void reloadSceneListItems()
        {
            SceneRewards.Items.Clear();
            SceneNames.Items.Clear();

            foreach (KeyValuePair<string, string> kvp in bindingsScene)
            {
                SceneRewards.Items.Add(kvp.Key);
                string[] val = kvp.Value.Split('\\');
                SceneNames.Items.Add(val[val.Length - 1]);
            }

            if (boxSelectionScene > (bindingsScene.Count - 1)) boxSelectionScene = (bindingsScene.Count - 1);

            if (bindingsScene.Count == 0)
            {
                //TODO: Set scene add reactions to false 
            }
            else
            {
                //TODO: Set scene add reactions to true
                SceneRewards.SelectedIndex = boxSelectionAudio;
                SceneNames.SelectedIndex = boxSelectionAudio;
                
            }
            saveBindingsScene();
        }

        private void reloadVideoListItems()
        {
            VideoRewards.Items.Clear();
            VideoUrls.Items.Clear();

            foreach (KeyValuePair<string, string> kvp in bindingsVideo)
            {
                VideoRewards.Items.Add(kvp.Key);
                string[] val = kvp.Value.Split('\\');
                VideoUrls.Items.Add(val[val.Length - 1]);
            }

            if (boxSelectionVideo > (bindingsVideo.Count - 1)) boxSelectionVideo = (bindingsVideo.Count - 1);

            if (bindingsVideo.Count == 0)
            {
                //TODO: Set scene add reactions to false 
            }
            else
            {
                //TODO: Set scene add reactions to true
                VideoRewards.SelectedIndex = boxSelectionVideo;
                VideoUrls.SelectedIndex = boxSelectionVideo;

            }
            saveBindingsVideo();
        }

        private static void LogEvent(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Saves the bindings array to the settings.txt file.
        /// </summary>
        private void saveBindingsAudio()
        {
            String buildString = "";
            foreach (KeyValuePair<string, string> kvp in bindingsAudio)
            {
                buildString += kvp.Key + "|" + kvp.Value + "\n";
            }
            File.WriteAllText("settingsAudio.txt", buildString);
        }

        /// <summary>
        /// Saves the bindings array to the settings.txt file.
        /// </summary>
        private void saveBindingsScene()
        {
            String buildString = "";
            foreach (KeyValuePair<string, string> kvp in bindingsScene)
            {
                buildString += kvp.Key + "|" + kvp.Value + "\n";
            }
            File.WriteAllText("settingsScene.txt", buildString);
        }

        private void saveBindingsVideo()
        {
            String buildString = "";
            foreach (KeyValuePair<string, string> kvp in bindingsVideo)
            {
                buildString += kvp.Key + "|" + kvp.Value + "\n";
            }
            File.WriteAllText("settingsVideo.txt", buildString);
        }

        /// <summary>
        /// Saves the bindings array to the settings.txt file.
        /// </summary>
        private void saveBindingsSceneSource()
        {
            String buildString = "";
            foreach (KeyValuePair<string, string> kvp in bindingsSceneSource)
            {
                buildString += kvp.Key + "|" + kvp.Value + "\n";
            }
            File.WriteAllText("settingsSceneSource.txt", buildString);
        }

        /// <summary>
        /// Decreases the boxSelectionAudio by one and highlights the appropriate items in the list boxes.
        /// </summary>
        private void btnUp_Click(object sender, EventArgs e)
        {
            boxSelectionAudio--;
            if (boxSelectionAudio < 0) boxSelectionAudio = 0;
            lstbxSoundsRewards.SelectedIndex = boxSelectionAudio;
            lstbxSoundsPaths.SelectedIndex = boxSelectionAudio;
        }

        /// <summary>
        /// Increases the boxSelectionAudio by one and highlights the appropriate items in the list boxes.
        /// </summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            boxSelectionAudio++;
            if (boxSelectionAudio > (bindingsAudio.Count - 1)) boxSelectionAudio = (bindingsAudio.Count - 1);
            lstbxSoundsRewards.SelectedIndex = boxSelectionAudio;
            lstbxSoundsPaths.SelectedIndex = boxSelectionAudio;
        }

        /// <summary>
        /// Prevents users from clicking on a listbox item.
        /// </summary>
        private void lstbxSoundsRewards_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxSoundsPaths.SelectedIndex = lstbxSoundsRewards.SelectedIndex;
        }

        int hoveredIndexRewards = -1;
        private void lstbxSoundsRewards_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // See which row is currently under the mouse:
            int newHoveredIndex = lstbxSoundsRewards.IndexFromPoint(e.Location);

            // If the row has changed since last moving the mouse:
            if (hoveredIndexRewards != newHoveredIndex)
            {
                // Change the variable for the next time we move the mouse:
                hoveredIndexRewards = newHoveredIndex;

                // If over a row showing data (rather than blank space):
                if (hoveredIndexRewards > -1)
                {
                    //Set tooltip text for the row now under the mouse:
                    toolTip1.Active = false;
                    toolTip1.SetToolTip(lstbxSoundsRewards, lstbxSoundsRewards.Items[hoveredIndexRewards].ToString());
                    toolTip1.Active = true;
                }
            }
        }

        /// <summary>
        /// Prevents users from clicking on a listbox item.
        /// </summary>
        private void lstbxSoundsPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxSoundsRewards.SelectedIndex = lstbxSoundsPaths.SelectedIndex;
        }

        int hoveredIndexPaths = -1;
        private void lstbxSoundsPaths_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // See which row is currently under the mouse:
            int newHoveredIndex = lstbxSoundsPaths.IndexFromPoint(e.Location);

            // If the row has changed since last moving the mouse:
            if (hoveredIndexPaths != newHoveredIndex)
            {
                // Change the variable for the next time we move the mouse:
                hoveredIndexPaths = newHoveredIndex;

                // If over a row showing data (rather than blank space):
                if (hoveredIndexPaths > -1)
                {
                    //Set tooltip text for the row now under the mouse:
                    toolTip1.Active = false;
                    bindingsAudio.TryGetValue(lstbxSoundsRewards.Items[hoveredIndexPaths].ToString(), out string fullPath);
                    toolTip1.SetToolTip(lstbxSoundsPaths, fullPath);
                    toolTip1.Active = true;
                }
            }
        }

        /// <summary>
        /// Removes the selected item from the bingings array and reloads the listboxes.
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Log($"Deleted item in AudioList [{lstbxSoundsRewards.SelectedItem.ToString()}]");
            bindingsAudio.Remove(lstbxSoundsRewards.SelectedItem.ToString());
            reloadAudioListItems();           
        }

        /// <summary>
        /// Tests the currently selected listbox item as if a Reward had been redeemed.
        /// </summary>
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (lstbxSoundsRewards.SelectedItem == null) return;
            bindingsAudio.TryGetValue(lstbxSoundsRewards.SelectedItem.ToString(), out string output);
            audioPlayer.PlaySound(output);
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            audioPlayer.StopAllPlayers();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmOptions optionsForm = new frmOptions();
            optionsForm.enSetBut += new ReenableSettingsButton(oFrmOptions_enSetBut);
            optionsForm.StartPosition = FormStartPosition.Manual;
            optionsForm.Location = this.Location;
            optionsForm.Icon = this.Icon;
            optionsForm.Show();
            btnSettings.Enabled = false;
        }

        void oFrmOptions_enSetBut()
        {
            btnSettings.Enabled = true;
        }

        private void btnEditTitle_Click(object sender, EventArgs e)
        {
            if (lstbxSoundsRewards.SelectedItem == null) return;
            bindingsAudio.TryGetValue(lstbxSoundsRewards.SelectedItem.ToString(), out string output);

            string rewardName = Prompt.ShowDialog("Enter the twitch Channel Points reward name EXACTLY as it is on twitch.", "Channel Reward Name");

            bindingsAudio.Remove(lstbxSoundsRewards.SelectedItem.ToString());
            bindingsAudio[rewardName] = output;
            reloadAudioListItems();
        }

        private void btnEditSound_Click(object sender, EventArgs e)
        {
            if (lstbxSoundsRewards.SelectedItem == null) return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    bindingsAudio[lstbxSoundsRewards.SelectedItem.ToString()] = filePath;
                    reloadAudioListItems();
                }
            }
        }

        private void AddSceneButton_Click(object sender, EventArgs e)
        {
            string rewardName = Prompt.ShowDialog("Enter the twitch Channel Points reward name EXACTLY as it is on twitch.", "Channel Reward Name");
            string SceneName = Prompt.ShowDialog("Enter the Scene name EXACTLY as it is on Streamlabs.", "Streamlabs Scene Name");

            bindingsScene.Add(rewardName, SceneName);
            reloadSceneListItems();
        }

        private void AddVideoButton_Click(object sender, EventArgs e)
        {
            string rewardName = Prompt.ShowDialog("Enter the twitch Channel Points reward name EXACTLY as it is on twitch.", "Channel Reward Name");
            string videoName = Prompt.ShowDialog("Enter a youtube link", "Youtube Link");

            bindingsVideo.Add(rewardName, videoName);
            reloadVideoListItems();
        }


        private void DeleteSceneButton_Click(object sender, EventArgs e)
        {
            Log($"Deleted item in SceneList [{SceneRewards.SelectedItem.ToString()}]");
            bindingsScene.Remove(SceneRewards.SelectedItem.ToString());
            reloadSceneListItems();      
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSceneSourceButton_Click(object sender, EventArgs e)
        {
            string rewardName = Prompt.ShowDialog("Enter the twitch Channel Points reward name EXACTLY as it is on twitch.", "Channel Reward Name");
            string SceneName = Prompt.ShowDialog("Enter the Scene source name EXACTLY as it is on Streamlabs.", "Streamlabs Scene Name");

            bindingsSceneSource.Add(rewardName, SceneName);
            reloadSceneSourceListItems();
        }

        private void DeleteSceneSourceButton_Click(object sender, EventArgs e)
        {
            Log($"Deleted item in SceneSourceList [{SceneSourceRewards.SelectedItem.ToString()}]");

            bindingsSceneSource.Remove(SceneSourceRewards.SelectedItem.ToString());
            reloadSceneSourceListItems();            
        }

        private void DeleteVideoButton_Click(object sender, EventArgs e)
        {
            Log($"Deleted item in VideoList [{VideoRewards.SelectedItem.ToString()}]");

            bindingsVideo.Remove(VideoRewards.SelectedItem.ToString());
            reloadVideoListItems();
        }

        private void TwitchConnectButton_Click(object sender, EventArgs e)
        {
            ConnectTwitchChat(TwitchUsernameInput.Text, TwitchOAuthInput.Text);
            string buildString = "";
            buildString += TwitchUsernameInput.Text + "|" + TwitchOAuthInput.Text;
            File.WriteAllText("settingsTwitch.txt", buildString);
        }

        private void ConnectTwitchChat(string username, string oauth)
        {
            new TwitchChatManager(this, username, oauth);
            ChatTextBox.Visible = true;
            SpeechChatCheckbox.Visible = true;
            TwitchLoginPanel.Visible = false;
            speechChat = new SpeechChat(this);
            SpeechChatComboBox.Visible = true;
            SpeechChatComboBox.Items.AddRange(speechChat.GetInstalledVoices().ToArray());
        }

        private void SpeechChatCheckbox_CheckedChanged(dynamic sender, EventArgs e)
        {
            if(sender.CheckState == CheckState.Checked)
            {
                speechChat.isTurnedOn = true;
                ChatMessageLog("SpeechChat is turned on!");
            }
            else
            {
                speechChat.isTurnedOn = false;
                ChatMessageLog("SpeechChat is turned off!");
            }
        }

        private void SpeechChatComboBox_SelectedIndexChanged(dynamic sender, EventArgs e)
        {
            speechChat.SelectVoice(sender.SelectedItem);
            ChatMessageLog($"Voice changed to {sender.SelectedItem}");
        }


        private void TTSSettingsButton_Click(object sender, EventArgs e)
        {
            if (TTSSettingsTabOpen)
            {
                TTSSettingsPanel.Visible = false;
                TTSSettingsTabOpen = false;
            }
            else
            {
                TTSSettingsPanel.Visible = true;
                TTSSettingsTabOpen = true;
            }
            
        }

        private void TTSSubscribersOnlyCheckbox_CheckedChanged(dynamic sender, EventArgs e)
        {
            if (sender.CheckState == CheckState.Checked) ttsSubscribersOnly = true;
            if (sender.CheckState == CheckState.Unchecked) ttsSubscribersOnly = false;

            ChatMessageLog($"TTS Sub only mode is turned {ttsSubscribersOnly}");
        }

        private void ChatTextBox_TextChanged(object sender, EventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmStartUpPrograms =  new frmStartUpPrograms();
            frmStartUpPrograms.Show();
        }

        private void SceneRewards_SelectedIndexChanged(object sender, EventArgs e)
        {
            SceneNames.SelectedIndex = SceneRewards.SelectedIndex;
        }

        private void SceneNames_SelectedIndexChanged(object sender, EventArgs e)
        {
           SceneRewards.SelectedIndex = SceneNames.SelectedIndex;
        }

        private void SceneSourceRewards_SelectedIndexChanged(object sender, EventArgs e)
        {
            SceneSourceNames.SelectedIndex = SceneSourceRewards.SelectedIndex;
        }

        private void SceneSourceNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SceneSourceRewards.SelectedIndex = SceneSourceNames.SelectedIndex;
        }

        /// <summary>
        /// Prompts user for the Channel Points Reward name and then opens an OpenFileDialog to select the file.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string rewardName = Prompt.ShowDialog("Enter the twitch Channel Points reward name EXACTLY as it is on twitch.", "Channel Reward Name");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    bindingsAudio.Add(rewardName, filePath);
                    reloadAudioListItems();
                }
            }
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, AutoSize = true, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                prompt.Dispose();
                return textBox.Text;
            }
            else
            {
                prompt.Dispose();
                return "";
            }

        }
    }
}
