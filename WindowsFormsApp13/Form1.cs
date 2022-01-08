using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void giris_buton_Click(object sender, EventArgs e)
        {
            string user = kullanici_textbox.Text;
            string pass = sifre_textbox.Text;
            con = new SqlConnection("Data Source=XX-BILGISAYAR\\SQLEXPRESS;Initial Catalog=teknik_hizmet_database;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where kullanici='" + kullanici_textbox.Text + "' AND sifre='" + sifre_textbox.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Form2 sayfa2 = new Form2();
                sayfa2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz.");
                kullanici_textbox.ResetText();
                sifre_textbox.ResetText();
            }
            con.Close();
        }
        private void sifregoster_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (sifregoster_checkBox1.Checked)
            {
                sifre_textbox.isPassword = false;
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                sifre_textbox.isPassword = true;
            }

        }
    }
}
