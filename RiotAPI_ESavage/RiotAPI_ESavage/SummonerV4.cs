using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille;
using Newtonsoft.Json;
using System.Net.Http;

using System;
using System.Threading.Tasks;
using System.Web;

namespace RiotAPI_ESavage
{
    public static class SummonerV4
    {

        private static readonly string RootURL = "https://br1.api.riotgames.com/lol/summoner/v4/summoners/by-name/";
        public static async Task<string> GetALL()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(RootURL + "/binti?api_key=RGAPI-27df923e-29c5-42ac-99af-3c247cca2c3d "))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if(data !=null)
                        {
                            return data;
                        }
                    }


                }

                
            }

            return string.Empty;
        }
    }
}

