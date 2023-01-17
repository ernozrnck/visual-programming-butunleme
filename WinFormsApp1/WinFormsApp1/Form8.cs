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
    public partial class Form8 : Form
    {
        Form3 frm;
        public Form8(Form3 frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string[][] ilaclar = Root.DB.Ilaclar();

            foreach (var item in ilaclar)
            {
                listBox1.Items.Add(item[0].ToString());
                listBox2.Items.Add(item[1].ToString());
            }


        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }
    }
}
