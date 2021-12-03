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
            var riotApi = RiotApi.NewInstance("RGAPI-b3258901-3962-4724-936d-e9b1878043dd");
            var summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA, "ChickenMessiah");
            Console.WriteLine($"Summoner: {summoner.Name} Level:{summoner.SummonerLevel}");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
