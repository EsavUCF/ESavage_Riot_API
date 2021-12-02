using System;
using System.IO;
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

        public object apiResponse { get; private set; }

        private async void GetAPIData_Click(object sender, EventArgs e)
        {
            var response = await SummonerV4.GetALL();
            apiResponse = response;//.text  = response;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
