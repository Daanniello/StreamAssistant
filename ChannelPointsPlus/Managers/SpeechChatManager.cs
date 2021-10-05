using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChannelPointsPlus
{
    public class SpeechChatManager
    {
        private frmMain _mainForm;
        private SpeechSynthesizer synthesizer;
        private SpeechSynthesizer forcedSynthesizer;
        private AutoResetEvent ttsEvent = new AutoResetEvent(false);
        public bool isTurnedOn = false;
        public bool isSpeaking = false;

        public SpeechChatManager(frmMain mainForm)
        {
            _mainForm = mainForm;
            synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();

            forcedSynthesizer = new SpeechSynthesizer();
            forcedSynthesizer.SetOutputToDefaultAudioDevice();
        }

        public async void ReadMessage(string message)
        {
            try
            {
                if (!message.StartsWith("!") && isTurnedOn == true)
                {
                    if (isSpeaking == false)
                    {
                        isSpeaking = true;
                        synthesizer.Speak(message);
                        isSpeaking = false;
                        ttsEvent.Set();
                    }
                    else
                    {
                        ttsEvent.WaitOne();
                        ReadMessage(message);
                    }
                }
            }
            catch(Exception ex)
            {
                _mainForm.LogException(ex.Message);
            }            
        }

        public async void ReadMessageForced(string message)
        {
            try
            {
                synthesizer.Pause();
                forcedSynthesizer.Speak(message);
                await Task.Delay(1000);
                synthesizer.Resume();
            }
            catch (Exception ex)
            {
                _mainForm.LogException(ex.Message);
            }         
        }

        public List<string> GetInstalledVoices()
        {
            var voices = new List<string>();

            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                voices.Add(voice.VoiceInfo.Name);
            }
            return voices;
        }

        public void SelectVoice(string name)
        {
            synthesizer.SelectVoice(name);
            forcedSynthesizer.SelectVoice(name);
        }
    }
}
