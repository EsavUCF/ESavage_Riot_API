using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.SummonerV4;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RiotAPI_ESavage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public object apiResponse { get; private set; }

        private void GetAPIData_Click(object sender, EventArgs e)   //Move load into into click to give windowed response. 
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/PKUltra?api_key=RGAPI-1714cac4-4d2b-4fcc-993c-e0859707d2d0");
            SummonerV4 summoner = JsonConvert.DeserializeObject<SummonerV4>(json);
            dataGridView1.DataSource = summoner;
            // MessageBox.Show(json);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
