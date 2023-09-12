using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fact_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public async Task<string> GetAsync(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public class ApiOutput
        {
            public string text { get; set; }
        }

        public class DayFactStorage
        {
            public static string EngDayFact = null;
            public static string GerDayFact = null;
        }

        private async void GenerateBtn_Click(object sender, EventArgs e)
        {
            string RequestResult;
            if (RandomFactSel.Checked == true)
            {
                if (EngSel.Checked == true)
                {
                    RequestResult = await GetAsync("https://uselessfacts.jsph.pl/api/v2/facts/random?language=en");
                    OutputTextBox.Text = RequestResult;
                }
                else
                {
                    RequestResult = await GetAsync("https://uselessfacts.jsph.pl/api/v2/facts/random?language=de");
                    OutputTextBox.Text = RequestResult;
                }
                ApiOutput ApiOutput = JsonConvert.DeserializeObject<ApiOutput>(RequestResult);
                OutputTextBox.Text = ApiOutput.text;
            }
            else
            {
                if (EngSel.Checked == true)
                {
                    if (DayFactStorage.EngDayFact == null)
                    {
                        DayFactStorage.EngDayFact = await GetAsync("https://uselessfacts.jsph.pl/api/v2/facts/today?language=en");
                    }
                    OutputTextBox.Text = JsonConvert.DeserializeObject<ApiOutput>(DayFactStorage.EngDayFact).text;
                }
                else
                {
                    if (DayFactStorage.GerDayFact == null)
                    {
                        DayFactStorage.GerDayFact = await GetAsync("https://uselessfacts.jsph.pl/api/v2/facts/today?language=de");
                    }
                    OutputTextBox.Text = JsonConvert.DeserializeObject<ApiOutput>(DayFactStorage.GerDayFact).text;
                }
            }
        }

        private void DayFactSelLabel_Click(object sender, EventArgs e)
        {
            RandomFactSel.Checked = false;
            DayFactSel.Checked = true;
        }

        private void RandomFactSelLabel_Click(object sender, EventArgs e)
        {
            DayFactSel.Checked = false;
            RandomFactSel.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
