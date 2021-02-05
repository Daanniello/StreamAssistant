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
        private VoiceCommands _voiceCommands;

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
            _voiceCommands = new VoiceCommands(_mainForm);
            foreach(var command in _voiceCommands.voiceCommands)
            {
                speechRecognition.LoadGrammar(command.Key);
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
            foreach(var command in _voiceCommands.voiceCommands)
            {
                if (e.Result.Grammar.Name == command.Key.Name) command.Value.Invoke();
            }
            //Turns off the recording
            //_shouldRecognize.Set();
        }

        class VoiceCommands
        {
            public Dictionary<Grammar, Action> voiceCommands = new Dictionary<Grammar, Action>();

            //TODO: a framework where we dont have to add other classes in here :c 
            public VoiceCommands(frmMain mainForm)
            {
                //THIS IS WHERE ALL THE COMMANDS ARE BEING MADE
                //COMMAND NAME, TEXT TO RECOGNIZE, ACTION TO EXECUTE
                //TTS Voice commands with the method to execute
                AddNewCommand("ttsOn", "turn tts on", () => { mainForm.SetSpeechChat(true); });
                AddNewCommand("ttsOff", "turn tts off", () => { mainForm.SetSpeechChat(false); });
                
                //Add all scene switched to the commands
                foreach (var scenes in mainForm.bindingsScene)
                {
                    AddNewCommand(scenes.Key, $"switch to {scenes.Key}", () => {
                        mainForm.bindingsScene.TryGetValue(scenes.Key, out string output);
                        mainForm.sceneChanger.ChangeScene(output, mainForm.GetSceneDuration());
                    });
                }

                //Add all scenesource activates to the commands
                foreach (var scenes in mainForm.bindingsSceneSource)
                {
                    AddNewCommand(scenes.Key, $"activate {scenes.Key}", () => {
                        mainForm.bindingsSceneSource.TryGetValue(scenes.Key, out string output);
                        mainForm.sceneSourceChanger.ChangeSceneSource(output, mainForm.GetSceneSourceDuration());
                    });
                }
            }

            private void AddNewCommand(string name, string command, Action methodToExcecute)
            {
                //Always add 'Hey streamassistant' to remove potential mistakes in voice
                voiceCommands.Add(new Grammar(new GrammarBuilder($"hey streamassistant, {command}")) { Name = name }, methodToExcecute);
            }
        }
    }
}
