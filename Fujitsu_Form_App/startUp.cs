using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Fujitsu_Form_App
{
    public partial class startUp : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private bool isSending = false;
        private readonly string wj_path = @"C:/shortCuts/start_wj.lnk";
        private readonly string mtg_path = @"C:/shortCuts/start_mtg.lnk";
        public startUp()
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
                string url = "http://192.168.0.102:10001/wayFinding";
                await SendGetRequestAsync(url);
                await StartProcessAsync(wj_path);
                this.Close();
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
                string url = "http://192.168.0.102:10001/mtg";
                await SendGetRequestAsync(url);
                await StartProcessAsync(mtg_path);
                this.Close();
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

        static async Task StartProcessAsync(string lnkFilePath) 
        {
            ProcessStartInfo psi = new ProcessStartInfo { FileName = lnkFilePath, UseShellExecute = true }; 
            await Task.Run(() => Process.Start(psi)); 
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