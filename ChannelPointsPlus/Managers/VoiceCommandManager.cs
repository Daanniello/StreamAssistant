using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChannelPointsPlus.Managers
{
    public class VoiceCommandManager
    {
        private frmMain _mainForm;
        private ManualResetEvent _shouldRecognize;

        public VoiceCommandManager(frmMain mainForm)
        {
            _mainForm = mainForm;
            //Starts the recognition in a new Thread
            new Task(() => { RecognizeCommands(); }).Start();
        }

        private async Task RecognizeCommands()
        {
            //Switch to turn off or on the recognition
            _shouldRecognize = new ManualResetEvent(false);

            //Setup the voice recognition
            //Record audio is the default input audio
            CultureInfo ci = new CultureInfo("en-us");
            var speechRecognition = new SpeechRecognitionEngine(ci);
            speechRecognition.SetInputToDefaultAudioDevice();

            //Adds all the voice commands
            var voiceCommands = new VoiceCommands();
            foreach(var command in voiceCommands.voiceCommands)
            {
                speechRecognition.LoadGrammar(command.Value);
            }

            //Add the event to call when something is recognized 
            speechRecognition.SpeechRecognized += SpeechRecognition_SpeechRecognized;

            //Start recognizing (recording)
            speechRecognition.RecognizeAsync(RecognizeMode.Multiple);

            //Waits until the recording is turned off
            _shouldRecognize.WaitOne(); 
            speechRecognition.Dispose(); 
        }

        private void SpeechRecognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Grammar.Name == "ttson") _mainForm.SetSpeechChat(true);
            if (e.Result.Grammar.Name == "ttsoff") _mainForm.SetSpeechChat(false);

            //Turns off the recording
            //_shouldRecognize.Set();
        }
    }

    class VoiceCommands
    {
        public Dictionary<string, Grammar> voiceCommands = new Dictionary<string, Grammar>();
        public VoiceCommands()
        {
            //TTS Voice commands
            Add("ttson", "turn tts on");
            Add("ttsoff", "turn tts off");
        }

        private void Add(string name, string command)
        {
            //Always add 'Hey streamassistant' to remove potential mistakes in voice
            voiceCommands.Add(name, new Grammar(new GrammarBuilder($"hey streamassistant, {command}")) { Name = name });            
        }
    }
}
