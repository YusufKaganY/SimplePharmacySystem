using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_ECZS_AppV0
{
    public partial class Form5 : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        public Form5()
        {
            InitializeComponent();
            Stil.FormDuzenle(this);
            Stil.GridDuzenle(dataGridView1);    
            Listele();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from Musteriler order by Ad asc", bgl.Baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Stil.GridDuzenle(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme HATASI: "+ex.Message);
            }
        }

        void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTel.Text = "";
            txtID.Text = "";
            cmbGuvence.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Musteriler (Ad,Soyad,TCKimlik,Telefon,SosyalGuvence) values (@p1,@p2,@p3,@p4,@p5)", bgl.Baglanti());

                komut.Parameters.AddWithValue("@p1",txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtTC.Text);//maksLength 11 !
                komut.Parameters.AddWithValue("@p4", txtTel.Text);
                komut.Parameters.AddWithValue("@p5", cmbGuvence.Text);
                //ID enabled FALSE da !!

                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Müşteri Eklendi!");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EKleme HATASI: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Lütfen listeden güncellenecek bir müşteri seçin.");
                    return;
                }
                SqlCommand komut = new SqlCommand("SP_MusteriGuncelle",bgl.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@MusteriID", Convert.ToInt32(txtID.Text));
                komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
                komut.Parameters.AddWithValue("@SosyalGuvence", cmbGuvence.Text);

                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();

                MessageBox.Show("Müşteri Bilgileri Güncellendi!");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Başlık satırına tıklanırsa hata vermesin
                if (e.RowIndex < 0) return;

                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                txtID.Text = dataGridView1.Rows[secilen].Cells["MusteriID"].Value.ToString();
                txtAd.Text = dataGridView1.Rows[secilen].Cells["Ad"].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[secilen].Cells["Soyad"].Value.ToString();
                txtTC.Text = dataGridView1.Rows[secilen].Cells["TCKimlik"].Value.ToString();
                txtTel.Text = dataGridView1.Rows[secilen].Cells["Telefon"].Value.ToString();
                cmbGuvence.Text = dataGridView1.Rows[secilen].Cells["SosyalGuvence"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: "+ ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
