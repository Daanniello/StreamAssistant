using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPointsPlus
{
    public class SpeechChatManager
    {
        private frmMain _mainForm;
        private SpeechSynthesizer synthesizer;
        public bool isTurnedOn = false;

        public SpeechChatManager(frmMain mainForm)
        {
            _mainForm = mainForm;
            synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();            
        }

        public async void ReadMessage(string message)
        {            
            if (!message.StartsWith("!") && isTurnedOn == true) synthesizer.Speak(message);
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
        }
    }
}
