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
    public partial class Form13 : Form
    {
        Form10 form10;
        public Form13(Form10 frm)
        {
            form10 = frm;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TC = richTextBox3.Text;
            string ad = richTextBox6.Text;
            string soyad = richTextBox5.Text;
            string sifre = richTextBox4.Text;
            Root.DB.PersonelEkle(TC, ad, soyad, CreateMD5(sifre));
            richTextBox3.Text = "";
            richTextBox6.Text = "";
            richTextBox5.Text = "";
            richTextBox4.Text = "";
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


        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
            form10.Show();
        }
    }
}
