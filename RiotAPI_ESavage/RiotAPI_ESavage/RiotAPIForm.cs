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

       

        private void GetAPIData_Click(object sender, EventArgs e)   //Move load into into click to give windowed response. 
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(textBox1.Text);
            SummonerV4 summoner = JsonConvert.DeserializeObject<SummonerV4>(json);
            string urlExtension = textBox1.Text.ToString();
            MessageBox.Show(summoner.name, "API Data Collected!", MessageBoxButtons.OKCancel);
     
            dataGridView1.DataSource = json;
            MessageBox.Show(json, "API Data Output");
            MessageBox.Show("Databinding was acting up so I did the process in a messagebox: Thanks for using RiotAPI_ESavage!");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "";
        }

        private void ClashV1Button_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string clashapi = client.DownloadString("https://na1.api.riotgames.com/lol/platform/v3/champion-rotations?api_key=RGAPI-1714cac4-4d2b-4fcc-993c-e0859707d2d0");
            MessageBox.Show(clashapi);
        }
    }
}
