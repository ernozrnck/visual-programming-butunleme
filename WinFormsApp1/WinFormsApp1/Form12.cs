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
    public partial class Form12 : Form
    {
        Form10 form10;
        public Form12(Form10 form10)
        {
            this.form10 = form10;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Root.DB.ilacSil(listBox1.SelectedItem.ToString());
            Form12_Load(new object(), new EventArgs());
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            string[][] ilaclar = Root.DB.Ilaclar();


            foreach (var item in ilaclar)
            {
                listBox1.Items.Add(item[0].ToString());
            }
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            form10.Show();
        }
    }
}
