using System;
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

        private void GetAPIData_Click(object sender, EventArgs e)                                     //This allows the user to type in a username rather than the entire URL to gather info. No Hardcoding a Key!
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://" + RegionBox.Text + ".api.riotgames.com/lol/summoner/v4/summoners/by-name/" + SummonerBox.Text + "?api_key=" + APIKeyBox.Text);
            SummonerV4 summoner = JsonConvert.DeserializeObject<SummonerV4>(json);
            string urlExtension = SummonerBox.Text.ToString();
            MessageBox.Show(summoner.name, "API Data Collected!", MessageBoxButtons.OKCancel);
     
            dataGridView1.DataSource = json;
            MessageBox.Show(json, "API Data Output");                                                 //Outputs the API URLs Information, however is a little messy, functionally capable. 
            MessageBox.Show("Databinding was acting up so I did the process in a messagebox: Thanks for using RiotAPI_ESavage!"); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ClashV1Button_Click(object sender, EventArgs e)                                 //orignally for clash but implemented Rotations. 
        {
            WebClient client = new WebClient();
            string clashapi = client.DownloadString("https://" + RegionBox.Text + ".api.riotgames.com/lol/platform/v3/champion-rotations?api_key=" + APIKeyBox.Text);
            MessageBox.Show(clashapi, "Rotation Data");
        }

        private void textBox2_TextChanged(object sender, EventArgs e) 
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string LoLStatus = client.DownloadString("https://" + RegionBox.Text + ".api.riotgames.com/lol/status/v3/shard-data?api_key=" + APIKeyBox.Text); //Esentially same workflow as Line 27, adds the user's string to the URL.
            MessageBox.Show(LoLStatus, "LoL Status:");
        }

        private void summonerV4BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
