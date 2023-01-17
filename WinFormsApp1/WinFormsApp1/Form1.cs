using MySqlConnector;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new(this);
            form7.Show();
            Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] kullanici = Root.DB.KullaniciGetir(richTextBox1.Text);

            if(kullanici != null)
            {
                string sifre = kullanici[2];
                string tamAd = kullanici[1];

                if (sifre == CreateMD5(richTextBox2.Text))
                {
                    Form3 form3 = new(this, tamAd);
                    form3.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Giris Basarisiz");
                }
            }
            else
            {
                MessageBox.Show("Hatali Kullanici Adý");
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


        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new(this);
            form4.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new(this);
            form5.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}