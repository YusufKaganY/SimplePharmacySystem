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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Stil.FormDuzenle(this);       // Formun boyutunu ayarla
            Stil.GridDuzenle(dataGridView1); // Tabloyu ayarla

            Listele();
            KategoriGetir();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        int secilenIlacID = 0;

        private void Form3_Load(object sender,EventArgs e)
        {
            //Listele();
            //KategoriGetir();
        }

        void Listele()
        {
            //MessageBox.Show("Listeleme yapıldı!");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *, dbo.fn_StokDurum(StokAdet) as [Stok Durumu],dbo.fn_TarihDurum(SKT) as Durum from Ilaclar", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            Stil.GridDuzenle(dataGridView1);
        }

        void KategoriGetir()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select KategoriID,KategoriAd from Kategoriler",bgl.Baglanti());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "KategoriID";
            cmbKategori.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Başlığa veya Geçersiz satıra tıklanırsa işlem yapma
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];//tiklanan satir

            // 2. EN ALTTAKİ BOŞ (YILDIZLI) SATIRA TIKLANIRSA DUR (Hatayı çözen kısım burası!)
            if (dataGridView1.Rows[e.RowIndex].IsNewRow) return;

            secilenIlacID = Convert.ToInt32(row.Cells["IlacID"].Value);

            txtBarkod.Text = row.Cells["BarkodNO"].Value.ToString();
            txtAd.Text = row.Cells["IlacAd"].Value.ToString();
            txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();
            txtStok.Text = row.Cells["StokAdet"].Value.ToString();
            dateSKT.Value = Convert.ToDateTime(row.Cells["SKT"].Value);
            cmbKategori.SelectedValue = row.Cells["KategoriID"].Value;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Bir Kategori Seçiniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);//uyarı simgeli
                return;//işlemi bitirir.
            }
            try
            {
                SqlCommand komut = new SqlCommand("SP_IlacEkle", bgl.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@BarkodNo", txtBarkod.Text);
                komut.Parameters.AddWithValue("@IlacAd", txtAd.Text);
                komut.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(txtFiyat.Text));//texti sayıya çeviriyoruz
                komut.Parameters.AddWithValue("@StokAdet", Convert.ToInt32(txtStok.Text));
                komut.Parameters.AddWithValue("@SKT", dateSKT.Value); //dateTimePicker olduğu için direkt value çekiyoruz
                komut.Parameters.AddWithValue("@KategoriID", Convert.ToInt32(cmbKategori.SelectedValue));

                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();

                MessageBox.Show("İlaç Başarıyla Eklendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//Bilgi Vermesi için ek
                Listele();//eklenen ilacı görmesi için tekrar listeleme
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
                bgl.Baglanti().Close();
            }
        }


        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        //SKT için satır boyama
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Satırın Durum hücresindeki değeri almas (SQL den gelen GECMIS/YAKLASMIS)
                if (row.Cells["Durum"].Value == null) continue;

                string durum = row.Cells["Durum"].Value.ToString();

                if (durum == "GECMIS")
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }
                else if (durum == "YAKLASMIS")
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenIlacID == 0)
                {
                    MessageBox.Show("Lütfen önce listeden güncellenecek ilacı seçin!");
                    return;
                }
                SqlCommand komut = new SqlCommand("UPDATE Ilaclar SET BarkodNo=@p1, IlacAd=@p2, Fiyat=@p3, StokAdet=@p4, SKT=@p5, KategoriID=@p6 WHERE IlacID=@p7", bgl.Baglanti());

                komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p4", txtStok.Text);
                komut.Parameters.AddWithValue("@p5", dateSKT.Value.Date);

                if (cmbKategori.SelectedValue != null)
                    komut.Parameters.AddWithValue("@p6", cmbKategori.SelectedValue);
                else
                    komut.Parameters.AddWithValue("@p6", DBNull.Value);
                komut.Parameters.AddWithValue("@p7", secilenIlacID);

                komut.ExecuteNonQuery();
                bgl.Baglanti().Close(); 

                MessageBox.Show("İlaç başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();

                txtBarkod.Text = "";
                txtAd.Text = "";
                txtFiyat.Text = "";
                txtStok.Text = "";
                secilenIlacID = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
        }
    }
}
