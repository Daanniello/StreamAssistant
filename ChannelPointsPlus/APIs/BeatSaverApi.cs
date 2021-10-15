using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPointsPlus.APIs
{
    public class BeatSaverApi
    {
        private static string baseUrl = "https://api.beatsaver.com";

        public BeatSaverApi()
        {

        }

        public static async Task<JObject> GetSongByHash(string songHash)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var request = new HttpRequestMessage()
                    {
                        RequestUri = new Uri($"{baseUrl}/maps/hash/{songHash}"),
                        Method = HttpMethod.Get,
                    };

                    var productValue = new ProductInfoHeaderValue("ScraperBot", "1.0");
                    var commentValue = new ProductInfoHeaderValue("(+http://www.example.com/ScraperBot.html)");

                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("*/*"));
                    client.DefaultRequestHeaders.UserAgent.Add(productValue);
                    client.DefaultRequestHeaders.UserAgent.Add(commentValue);

                    var httpResponseMessage2 = await client.SendAsync(request);
                    var recentSongsJsonDataBeatSaver = await httpResponseMessage2.Content.ReadAsStringAsync();
                    var recentSongsInfoBeatSaver = JsonConvert.DeserializeObject(recentSongsJsonDataBeatSaver);
                    var songInfo = JObject.Parse(recentSongsInfoBeatSaver.ToString());

                    return songInfo;
                }
            }
            catch(Exception ex)
            {
                return null;
            }                 
        }

        public static async Task<JToken> GetMostRecentSongInfo()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var request = new HttpRequestMessage()
                    {
                        RequestUri = new Uri($"{baseUrl}/maps/latest"),
                        Method = HttpMethod.Get,
                    };

                    var productValue = new ProductInfoHeaderValue("ScraperBot", "1.0");
                    var commentValue = new ProductInfoHeaderValue("(+http://www.example.com/ScraperBot.html)");

                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("*/*"));
                    client.DefaultRequestHeaders.UserAgent.Add(productValue);
                    client.DefaultRequestHeaders.UserAgent.Add(commentValue);

                    var httpResponseMessage2 = await client.SendAsync(request);
                    var recentSongsJsonDataBeatSaver = await httpResponseMessage2.Content.ReadAsStringAsync();
                    var recentSongsInfoBeatSaver = JsonConvert.DeserializeObject(recentSongsJsonDataBeatSaver);
                    var songInfo = JObject.Parse(recentSongsInfoBeatSaver.ToString())["docs"].First();

                    return songInfo;
                }
            }
            catch
            {
                return null;
            }
        }

        public static async Task<JToken> GetSongByKey(string songKey)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var request = new HttpRequestMessage()
                    {
                        RequestUri = new Uri($"{baseUrl}/maps/id/{songKey}"),
                        Method = HttpMethod.Get,
                    };

                    var productValue = new ProductInfoHeaderValue("ScraperBot", "1.0");
                    var commentValue = new ProductInfoHeaderValue("(+http://www.example.com/ScraperBot.html)");

                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("*/*"));
                    client.DefaultRequestHeaders.UserAgent.Add(productValue);
                    client.DefaultRequestHeaders.UserAgent.Add(commentValue);

                    var httpResponseMessage2 = await client.SendAsync(request);
                    var recentSongsJsonDataBeatSaver = await httpResponseMessage2.Content.ReadAsStringAsync();
                    var recentSongsInfoBeatSaver = JsonConvert.DeserializeObject(recentSongsJsonDataBeatSaver);
                    var songInfo = JObject.Parse(recentSongsInfoBeatSaver.ToString());

                    return songInfo;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static async Task<int> GetTotalMapCount()
        {
            var latestSongInfo = await GetMostRecentSongInfo();
            var key = latestSongInfo["id"].ToString();
            //Converts the hex key to a real number 
            var mapAmount = Convert.ToInt32(key, 16);
            return mapAmount;
        }
    }
}
