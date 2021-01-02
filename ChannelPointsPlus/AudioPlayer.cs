using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media;

namespace ChannelPointsPlus
{
    public class AudioPlayer
    {
        private static MediaPlayer thePlayer;
        public static List<MediaPlayer> allPlayers = new List<MediaPlayer>();
        private frmMain mainForm;

        public AudioPlayer(frmMain mainForm)
        {
            this.mainForm = mainForm;

            // Adds the audios from settings at start 
            if (File.Exists("settingsAudio.txt"))
            {
                String[] loadSettings = File.ReadAllLines("settingsAudio.txt");
                foreach (string line in loadSettings)
                {
                    string[] split = line.Split('|');
                    mainForm.bindingsAudio.Add(split[0], split[1]);
                }
            }
        }

        /// <summary>
        /// Plays a sound file from a path.
        /// </summary>
        /// <param name="filename">The path to the sound file to play.</param>
        public async void PlaySound(string filename)
        {
            thePlayer = new MediaPlayer();
            thePlayer.Open(new Uri(filename));
            this.SetVolume(mainForm.GetAudioVolumeLevel());
            thePlayer.MediaEnded += ThePlayer_MediaEnded;
            mainForm.SetStopAllPlayersButton(true);
            allPlayers.Add(thePlayer);
            thePlayer.Play();
        }

        /// <summary>
        /// Closes the media file once it's done playing.
        /// </summary>
        private void ThePlayer_MediaEnded(object sender, EventArgs e)
        {
            thePlayer.Close();
            allPlayers.Remove((MediaPlayer)sender);
        }

        public void StopAllPlayers()
        {
           foreach(var audioPlay in allPlayers)
            {
                audioPlay.Stop();
            }
        }

        /// <summary>
        /// Sets the volume level for the MediaPlayer object.
        /// </summary>
        /// <param name="volume">Assumed to be between 0 and 100.</param>
        public void SetVolume(int volume)
        {
            // MediaPlayer volume is a float value between 0 and 1.
            thePlayer.Volume = volume / 100.0f;
        }
    }
}
