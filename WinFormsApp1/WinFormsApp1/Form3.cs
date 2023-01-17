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
    public partial class Form3 : Form
    {
        readonly Form1 frm;
        readonly string TamAd;
        public Form3(Form1 frm, string kullaniciAd)
        {
            TamAd = kullaniciAd;
            this.frm = frm;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = TamAd;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new(frm);
            form7.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(this);
            form2.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new(this);
            form6.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new(this);
            form8.Show();
            Hide();

        }
    }
}
