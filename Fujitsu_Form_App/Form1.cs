using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fujitsu_Form_App
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private bool isSending = false;
        public Form1()
        {
            InitializeComponent();
        }

        //WJ
        private async void button1_Click(object sender, EventArgs e)
        {
            if (isSending) return;
            isSending = true;

            try
            {
                button_Mtg.Enabled = false;
                string url = "http://192.168.12.126:10001/wayFinding";
                await SendGetRequestAsync(url);
            }
            catch
            {
                MessageBox.Show("WayFinding_Journeyの起動に失敗しました: ");
                button_Mtg.Enabled = true;
                isSending = false;
            }
        }

        //Mtg
        private async void button2_Click(object sender, EventArgs e)
        {
            if (isSending) return;
            isSending = true;

            try
            {
                button_Wj.Enabled = false;
                string url = "http://192.168.12.126:10001/mtg";
                await SendGetRequestAsync(url);
            }
            catch
            {
                MessageBox.Show("2030年の経営会議の起動に失敗しました: ");
                button_Wj.Enabled = true;
                isSending = false;
            }
        }

        private async Task SendGetRequestAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("エラー: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}