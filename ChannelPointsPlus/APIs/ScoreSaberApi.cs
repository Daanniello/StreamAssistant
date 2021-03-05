using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPointsPlus.APIs
{
    public class ScoreSaberApi
    {
        public ScoreSaberApi()
        {

        }

        public static async Task<JToken> GetRecentSongDataAsync(string scoresaberID)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var recentSongDataRaw = await client.GetStringAsync($"https://new.scoresaber.com/api/player/{scoresaberID}/scores/recent/1");
                    var result = JsonConvert.DeserializeObject(recentSongDataRaw);
                    var scores = JObject.Parse(result.ToString())["scores"].First();

                    return scores;
            }
            }
            catch
            {
                return null;
            }                
        }
    }
}
