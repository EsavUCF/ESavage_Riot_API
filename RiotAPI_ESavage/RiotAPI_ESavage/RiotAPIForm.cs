using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

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
            WebClient client = new WebClient();
            string json = client.DownloadString("https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/Vine?api_key=RGAPI-b3258901-3962-4724-936d-e9b1878043dd");
            MessageBox.Show(json);
        }

        public object apiResponse { get; private set; }

        private async void GetAPIData_Click(object sender, EventArgs e)   //Move load into into click to give windowed response. 
        {
            var response = await SummonerV4.GetALL();
            apiResponse = response;//.text  = response;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
