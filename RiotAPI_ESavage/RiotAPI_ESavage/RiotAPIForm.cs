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
            string json = client.DownloadString(textBox1.Text);
            SummonerV4 summoner = JsonConvert.DeserializeObject<SummonerV4>(json);
            string urlExtension = textBox1.Text.ToString();
            MessageBox.Show(summoner.name, "API Data Collected!");
            dataGridView1.DataSource = summoner;
            MessageBox.Show(json);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
