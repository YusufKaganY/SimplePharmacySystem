using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //!!!

namespace VTYS_ECZS_AppV0
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("exec SP_PersonelGirisKontrol @p1, @p2", bgl.Baglanti());

            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                Program.GirisYapanAdSoyad = reader["AdSoyad"].ToString();
                Program.GirisYapanID = reader["PersonelID"].ToString();
                MessageBox.Show("Giriş Başarılı, Hoşgeldiniz " + reader["AdSoyad"].ToString());
                //Form2 kısmına geçiş
                Form2 anaMenu = new Form2();
                anaMenu.Show();
                this.Hide();//form1 i sakla
            }
            else
            {
                MessageBox.Show("Hatalı Ad veya Şifre !!!");
            }
            bgl.Baglanti().Close();
        }
    }
}
