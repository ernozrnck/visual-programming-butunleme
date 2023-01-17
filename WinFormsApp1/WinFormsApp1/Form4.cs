using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        Form1 frm;
        public Form4(Form1 frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox3.Text == richTextBox2.Text)
            {
                string TC = richTextBox1.Text;
                string tamAd = richTextBox4.Text;
                string turkmu;
                if (checkBox1.Checked)
                {
                    turkmu = "0";
                }
                else
                {
                    turkmu = "1";
                }

                Root.DB.KullaniciEkle(TC, tamAd, CreateMD5(richTextBox3.Text), turkmu);
                MessageBox.Show("Kaydiniz Yapilmistir. Giris Yapabilirsiniz");
            }
            else
            {
                MessageBox.Show("Hata");
            }


        }


        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes); // .NET 5 +

                // Convert the byte array to hexadecimal string prior to .NET 5
                // StringBuilder sb = new System.Text.StringBuilder();
                // for (int i = 0; i < hashBytes.Length; i++)
                // {
                //     sb.Append(hashBytes[i].ToString("X2"));
                // }
                // return sb.ToString();
            }
        }



    }
}
