using MySqlConnector;
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
    public partial class Form5 : Form
    {
        Form1 frm;
        public Form5(Form1 frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] personel = Root.DB.PersonelGetir(richTextBox1.Text);
            string sifre;

            if(personel != null)
            {
                sifre = personel[3];


                if (sifre == CreateMD5(richTextBox2.Text))
                {
                    MessageBox.Show("Giris Basarili");
                    Form10 form10 = new(frm);
                    form10.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Giris Basarisiz");
                }

            }
            else
            {
                MessageBox.Show("Hatali Kullanici Adi Veya Sifre");
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
