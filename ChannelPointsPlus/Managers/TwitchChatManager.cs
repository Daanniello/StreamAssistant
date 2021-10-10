using ChannelPointsPlus.APIs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace ChannelPointsPlus
{
    public class TwitchChatManager
    {
        private frmMain _mainForm;                
        public TwitchApi _twitchApi;
        public bool isReseted = false;

        //TODO API needs to be in a sepperate class 'TwitchAPI'

        public TwitchChatManager(frmMain mainForm, TwitchApi twitchApi)
        {
            _mainForm = mainForm;
            _twitchApi = twitchApi;

            _twitchApi.client.OnMessageReceived += Client_OnMessageReceived;
        } 

        public async void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            _mainForm.ChatMessageLog($"{ e.ChatMessage.Username}: {e.ChatMessage.Message}");

            if (isReseted) return;

            if (_mainForm.ttsSubscribersOnly)
            {               
                if (e.ChatMessage.IsSubscriber)
                {
                    if (_mainForm.speechChat.isTurnedOn)
                    {                       
                        _mainForm.speechChat.ReadMessage(_mainForm.ttsSpeakOutUsername == true ? $"{(e.ChatMessage.Message.StartsWith("!") ? "!" + e.ChatMessage.Username : e.ChatMessage.Username)} says... {e.ChatMessage.Message}" : $"{e.ChatMessage.Message}");
                    }
                }
            }
            else
            {
                if (_mainForm.speechChat.isTurnedOn)
                {
                    _mainForm.speechChat.ReadMessage(_mainForm.ttsSpeakOutUsername == true ? $"{(e.ChatMessage.Message.StartsWith("!") ? "!" + e.ChatMessage.Username : e.ChatMessage.Username)} says... {e.ChatMessage.Message}" : $"{e.ChatMessage.Message}");
                }
            }
        }      
    }
}
