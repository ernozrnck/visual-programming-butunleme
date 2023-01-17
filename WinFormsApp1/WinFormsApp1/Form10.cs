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
    public partial class Form10 : Form
    {
        Form1 frm;
        public Form10(Form1 frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string[][] ilaclar = Root.DB.Ilaclar();


            foreach (var item in ilaclar)
            {
                listBox1.Items.Add(item[0].ToString());
                listBox2.Items.Add(item[1].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new(this);
            form9.Show();
            this.Hide();
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new(this);
            form11.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 form12 = new(this);
            form12.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10_Load(new object(), new EventArgs());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 form13 = new(this);
            form13.Show();
            this.Hide();
        }
    }
}
