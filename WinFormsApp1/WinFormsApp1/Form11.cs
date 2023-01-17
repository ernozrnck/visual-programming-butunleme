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
    public partial class Form11 : Form
    {
        Form10 frm;
        public Form11(Form10 frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ilacIsmi = textBox1.Text;
            string ilacUreticisi = textBox2.Text;
            Root.DB.ilacEkle(ilacIsmi, ilacUreticisi);
            textBox1.Text = textBox2.Text = "";
            Form11_Load(new object(), new EventArgs());
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            string[][] ilaclar = Root.DB.Ilaclar();


            foreach (var item in ilaclar)
            {
                listBox1.Items.Add(item[0].ToString());
            }
        }
    }
}
