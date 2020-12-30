﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPointsPlus
{
    public class SpeechChat
    {
        private SpeechSynthesizer synthesizer;
        public bool isTurnedOn = false;

        public SpeechChat()
        {
            synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();            
        }

        public void ReadMessage(string message)
        {
            synthesizer.Speak(message);
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