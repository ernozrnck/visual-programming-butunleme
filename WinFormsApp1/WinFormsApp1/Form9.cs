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
    public partial class Form9 : Form
    {
        Form10 frm;
        public Form9(Form10 frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            string[][] ilaclar = Root.DB.Ilaclar();


            foreach (var item in ilaclar)
            {
                listBox1.Items.Add(item[0].ToString());
            }

        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                textBox2.Text = Root.DB.ilacGetir(textBox1.Text)[0];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ilacIsmi = textBox1.Text;
            string ilacUreticisi = textBox2.Text;
            Root.DB.IlacGuncelle(listBox1.SelectedItem.ToString(), ilacIsmi, ilacUreticisi);

            Form9_Load(new object(), new EventArgs());

            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.SelectedIndex = -1;
        }
    }
}
