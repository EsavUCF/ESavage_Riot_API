using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using System.Windows.Forms;

namespace RiotAPI_ESavage
{
    class Program
    {
       
        [STAThread]
        static void Main(string[] args)
        {
            var riotApi = RiotApi.NewInstance("RGAPI-8b51a20f-e0b5-416f-8dfb-67e49ff51275");
            var summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA, "PKUltra");
            Console.WriteLine($"Summoner: {summoner.Name} Level:{summoner.SummonerLevel}");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
