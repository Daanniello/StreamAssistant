using SLOBSharp.Client;
using SLOBSharp.Client.Requests;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelPointsPlus
{
    public class SceneSourceChanger
    {
        private frmMain _mainForm;
        private SlobsPipeClient slobsClient;
        public SceneSourceChanger(frmMain mainForm)
        {
            _mainForm = mainForm;
            slobsClient = mainForm.slobsClient;

            // Adds the scenes from settings at start 
            if (File.Exists("settingsSceneSource.txt"))
            {
                String[] loadSettings = File.ReadAllLines("settingsSceneSource.txt");
                foreach (string line in loadSettings)
                {
                    string[] split = line.Split('|');
                    mainForm.bindingsSceneSource.Add(split[0], split[1]);
                }
            }
        }

        public async void ChangeSceneSource(string sceneSourceName, int sceneChangeDuration)
        {
            //Streamlabs        
            //Gets the active scene
            var slobsCurrentSceneRequest = SlobsRequestBuilder.NewRequest().SetMethod("activeScene").SetResource("ScenesService").BuildRequest();
            var slobsCurrentSceneRpcResponse = await slobsClient.ExecuteRequestAsync(slobsCurrentSceneRequest).ConfigureAwait(false);
            var currentScene = slobsCurrentSceneRpcResponse.Result.FirstOrDefault();
            var item = currentScene.Nodes.Where(x => x.Name == sceneSourceName).FirstOrDefault();

            if (item == null)
            {
                _mainForm.Log("Change Scene Source was not found.. The Source name is not equal to one of the sources in the current scene.");
                return;
            }

            ////Sets the scene to the requested one 
            var slobsRequest2 = SlobsRequestBuilder.NewRequest().SetMethod("setVisibility").SetResource(item.ResourceId).AddArgs(true).BuildRequest();
            var slobsRpcResponse2 = await slobsClient.ExecuteRequestAsync(slobsRequest2).ConfigureAwait(false);
            await Task.Delay(Convert.ToInt32(sceneChangeDuration) * 1000);
            var slobsRequest3 = SlobsRequestBuilder.NewRequest().SetMethod("setVisibility").SetResource(item.ResourceId).AddArgs(false).BuildRequest();
            var slobsRpcResponse3 = await slobsClient.ExecuteRequestAsync(slobsRequest3).ConfigureAwait(false);

        }
    }
}
