using SLOBSharp.Client;
using SLOBSharp.Client.Requests;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelPointsPlus
{
    public class SceneChanger
    {
        private SlobsPipeClient slobsClient;
        private frmMain mainForm;

        public SceneChanger(frmMain mainForm)
        {
            this.mainForm = mainForm;
            slobsClient = mainForm.slobsClient;       

            // Adds the scenes from settings at start 
            if (File.Exists("settingsScene.txt"))
            {
                String[] loadSettings = File.ReadAllLines("settingsScene.txt");
                foreach (string line in loadSettings)
                {
                    string[] split = line.Split('|');
                    mainForm.bindingsScene.Add(split[0], split[1]);
                }
            }
        }

        public async void ChangeScene(string sceneName, int sceneChangeDuration)
        {
            //Streamlabs        
            //Gets the active scene
            var slobsCurrentSceneRequest = SlobsRequestBuilder.NewRequest().SetMethod("activeScene").SetResource("ScenesService").BuildRequest();
            var slobsCurrentSceneRpcResponse = await slobsClient.ExecuteRequestAsync(slobsCurrentSceneRequest).ConfigureAwait(false);
            var currentScene = slobsCurrentSceneRpcResponse.Result.FirstOrDefault();

            //Gets all the scenes 
            var slobsScenesRequest = SlobsRequestBuilder.NewRequest().SetMethod("getScenes").SetResource("ScenesService").BuildRequest();
            var slobsScenesRpcResponse = await slobsClient.ExecuteRequestAsync(slobsScenesRequest).ConfigureAwait(false);
            var scene = slobsScenesRpcResponse.Result.Where(x => x.Name == sceneName).FirstOrDefault();

            if (scene == null)
            {
                mainForm.Log("Scene was not found.. The name of the scene is equal to one in the scenescollection.");
                return;
            }

            //Sets the scene to the requested one 
            var slobsRequest2 = SlobsRequestBuilder.NewRequest().SetMethod("makeSceneActive").SetResource("ScenesService").AddArgs(scene.Id).BuildRequest();
            var slobsRpcResponse2 = await slobsClient.ExecuteRequestAsync(slobsRequest2).ConfigureAwait(false);
            await Task.Delay(Convert.ToInt32(sceneChangeDuration) * 1000);
            //Sets back the scene to the normal one
            var slobsMakeActiveRequest = SlobsRequestBuilder.NewRequest().SetMethod("makeSceneActive").SetResource("ScenesService").AddArgs(currentScene.Id).BuildRequest();
            var slobsMakeActiveRpcResponse = await slobsClient.ExecuteRequestAsync(slobsMakeActiveRequest).ConfigureAwait(false);

        }
    }
}
