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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=XX-BILGISAYAR\\SQLEXPRESS;Initial Catalog=teknik_hizmet_database;Integrated Security=True");

        private void verilerimi_goster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from ariza_kayit", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            baglan.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customizeDesign()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel5.Visible == true)
                panel5.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void apart_ısı_merkezi_buton_Click(object sender, EventArgs e)
        {
            showSubmenu(panel2);
        }

        private void bahçe_sulama_buton_Click(object sender, EventArgs e)
        {
            showSubmenu(panel3);
        }
        private void endeks_buton_Click(object sender, EventArgs e)
        {
            showSubmenu(panel6);
        }




        private void ariza_kayit_programi_buton_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'teknik_hizmet_databaseDataSet13.Table_elektrikana' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_elektrikanaTableAdapter1.Fill(this.teknik_hizmet_databaseDataSet13.Table_elektrikana);
                                                         
        }

        private void endeks_elektrik_buton_Click(object sender, EventArgs e)
        {
            {
                if (panel_elektrik_ana.Visible)
                    panel_elektrik_ana.Visible = false;

                else
                    panel_elektrik_ana.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
                 

        private void hesap_kaydet_Click_1(object sender, EventArgs e)
        {
            

        }

        private void hesap_kaydet_Click(object sender, EventArgs e)
        {
            

            if (aktif1_textbox.Text == "" && aktif2_textbox.Text == "" &&
                        enduktif1_textbox.Text == "" && enduktif2_textbox.Text == "" &&
                        kapasitif1_textbox.Text == "" && kapasitif2_textbox.Text == "")
            {
                MessageBox.Show(" Boş alan bırakmayınız");               

            }

            else

            {
                panel10.Visible = true;
            }
                                


            float akt1 = float.Parse(aktif1_textbox.Text);
            float akt2 = float.Parse(aktif2_textbox.Text);
            float akt_fark = akt2 - akt1;
            aktif_fark_textbox.Text = Convert.ToString(akt_fark);

            float end1 = float.Parse(enduktif1_textbox.Text);
            float end2 = float.Parse(enduktif2_textbox.Text);
            float end_fark = end2 - end1;
            enduktif_fark_textbox.Text = Convert.ToString(end_fark);

            float kap1 = float.Parse(kapasitif1_textbox.Text);
            float kap2 = float.Parse(kapasitif2_textbox.Text);
            float kap_fark = kap2 - kap1;
            kapasitif_fark_textbox.Text = Convert.ToString(kap_fark);

            float end_oran_son = (end_fark / akt_fark) * 100;
            enduktif_oran_textbox.Text = Convert.ToString(end_oran_son);
            float kap_oran_son = (kap_fark / akt_fark) * 100;
            kapasitif_oran_textbox.Text = Convert.ToString(kap_oran_son);

            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into Table_elektrikana(tarih,aktif_ilk_deger,aktif_son_deger,aktif_fark,enduktif_ilk_deger,enduktif_son_deger,enduktif_fark,enduktif_oran,kapasitif_ilk_deger,kapasitif_son_deger,kapasitif_fark,kapasitif_oran) " +
                    "values (@tarih,@a1,@a2,@af,@e1,@e2,@ef,@eo,@k1,@k2,@kf,@ko)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut1 = new SqlCommand(kayit, baglan);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut1.Parameters.AddWithValue("@tarih", timepicker.Value);
                komut1.Parameters.AddWithValue("@a1", aktif1_textbox.Text);
                komut1.Parameters.AddWithValue("@a2", aktif2_textbox.Text);
                komut1.Parameters.AddWithValue("@af", aktif_fark_textbox.Text);
                komut1.Parameters.AddWithValue("@e1", enduktif1_textbox.Text);
                komut1.Parameters.AddWithValue("@e2", enduktif2_textbox.Text);
                komut1.Parameters.AddWithValue("@ef", enduktif_fark_textbox.Text);
                komut1.Parameters.AddWithValue("@eo", enduktif_oran_textbox.Text);
                komut1.Parameters.AddWithValue("@k1", kapasitif1_textbox.Text);
                komut1.Parameters.AddWithValue("@k2", kapasitif2_textbox.Text);
                komut1.Parameters.AddWithValue("@kf", kapasitif_fark_textbox.Text);
                komut1.Parameters.AddWithValue("@ko", kapasitif_oran_textbox.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut1.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglan.Close();
                
                MessageBox.Show("Kaydedildi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            {   // Sihirbaz ile oluşan DataAdapter adının denemeAdapter ve Dataset adının denemeDataSet olduğunu varsayarak
                this.table_elektrikanaTableAdapter1.Update(this.teknik_hizmet_databaseDataSet13.Table_elektrikana);
                dataGridView1.DataSource = this.teknik_hizmet_databaseDataSet13.Table_elektrikana;
                
                
            }
        }
    }
}
