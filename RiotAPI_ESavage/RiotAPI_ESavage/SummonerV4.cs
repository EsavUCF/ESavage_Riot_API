using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille;
using Newtonsoft.Json;
using System.Net.Http;

using System;
using System.Threading.Tasks;
using System.Web;

namespace RiotAPI_ESavage
{
    class SummonerV4
    {
       
        public string id { get; set; }

        public string accountId { get; set; }

      
        public string puuid { get; set; }

        public string name { get; set; }

        
        public int profileIconId { get; set; }

       
        public long revisionDate { get; set; }

       
        public long summonerLevel { get; set; }
    }
}