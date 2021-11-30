//using MingweiSamuel.Camille.SummonerV4;
//using Newtonsoft.Json;
//using System;
//using System.Threading.Tasks;
//using System.Web;
//
//namespace RiotAPI_ESavage
//{
//    class SummonerV4
//    {
//        [JsonProperty("id")]
//        public string ID { get; set; }
//
//        [JsonProperty("accountId")]
//        public string AccountID { get; set; }
//
//        [JsonProperty("puuid")]
//        public string PuuID { get; set; }
//
//        [JsonProperty("name")]
//        public string Name { get; set; }
//
//        [JsonProperty("profileIconId")]
//        public int ProfileIconId { get; set; }
//
//        [JsonProperty("revisionDate")]
//        public long RevisionDate { get; set; }
//
//        [JsonProperty("summonerLevel")]
//        public long SummerLevel { get; set; }
//    }
//    public Summoner GetSummonerByName(string summonerName)
//    {
//        var uriBuilder = new UriBuilder($"{ApiBaseAddress}/by-name/{summonerName}");
//        var query = HttpUtility.ParseQueryString(uriBuilder.Query);
//        query["api_key"] = Api.ApiKey;
//        uriBuilder.Query = query.ToString();
//        string requestUri = uriBuilder.ToString();
//
//
//        var response = Api.Client.GetAsync(requestUri).Result;
//        if (response.IsSuccessStatusCode == false)
//        {
//            throw new Exception($"Request Failed. Reponse:{response.StatusCode}");
//        }
//        string jsonResponse = response.Content.ReadAsStringAsync().Result;
//        return JsonConvert.DeserializeObject<Summoner>(jsonResponse);
//        
//    }
//
//    public async Task<Summoner> GetSummonerByNameAsync(string summonerName);
//
//}

