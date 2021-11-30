using Newtonsoft.Json;

namespace RiotAPI_ESavage
{
    class Summoner
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("accountId")]
        public string AccountID { get; set; }

        [JsonProperty("puuid")]
        public string PuuID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummerLevel { get; set; }
    }
}
