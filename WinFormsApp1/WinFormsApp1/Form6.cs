using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        Form3 frm;
        public Form6(Form3 frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://mahabub81.github.io/covid-19-api/api/v1/world-summary.json");
                httpWebRequest.ContentType = "application/json";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);

                    string[] veriDizisi = { (string)data["last_update"], (string)data["confirmed"], (string)data["deaths"], (string)data["recovered"], (string)data["active"] };

                    label2.Text += veriDizisi[0];
                    label3.Text += veriDizisi[1];
                    label4.Text += veriDizisi[2];
                    label5.Text += veriDizisi[3];
                    label6.Text += veriDizisi[4];
                }
            }
            catch
            {
                MessageBox.Show("Internet Baglantisi Hatasi");
            }

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }
    }
}
