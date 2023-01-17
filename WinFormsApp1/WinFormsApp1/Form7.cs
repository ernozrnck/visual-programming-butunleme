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
    public partial class Form7 : Form
    {
        readonly Form1 frm;
        public Form7(Form1 frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }
    }
}
