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
    public partial class Form4 : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        DataTable dtSepet = new DataTable();

        public Form4()
        {
            InitializeComponent();
            Stil.FormDuzenle(this);
            SetupSepet();
            MusteriGetir();
            IlacGetir("");
            lblToplamTutar.Text = "0.00 TL";
            Stil.GridDuzenle(gridIlaclar);
            Stil.GridDuzenle(gridSepet);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //MusteriGetir();
            //IlacGetir(""); // hepsini getirmesi için boş bırakıyorum
            //lblToplamTutar.Text = "0.00 TL";

        }

        void MusteriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MusteriID, (Ad + ' ' + Soyad) as AdSoyad from Musteriler", bgl.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "MusteriID";
            cmbMusteri.DataSource = dt;

        }

        void IlacGetir(string kelime)
        {
            SqlCommand komut = new SqlCommand("SP_IlacAra",bgl.Baglanti());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Kelime", kelime);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridIlaclar.DataSource = dt;
            Stil.GridDuzenle(gridIlaclar);
        }

        void SetupSepet()
        {
            dtSepet.Columns.Add("IlacID", typeof(int));
            dtSepet.Columns.Add("İlaç Adı", typeof(String));
            dtSepet.Columns.Add("Adet", typeof(int));
            dtSepet.Columns.Add("Fiyat", typeof(decimal));
            dtSepet.Columns.Add("Tutar", typeof(decimal));

            gridSepet.DataSource = dtSepet;
            Stil.GridDuzenle(gridSepet);

            gridSepet.Columns["IlacID"].Visible = false; //kullanıcının ilacID sini görmesi pek mantıklı değil bu yüzden gizledim
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            IlacGetir(txtAra.Text); //arama kutusuna her girişte arama yapacak
        }

        void ToplamHesapla()
        {
            decimal genelToplam = 0;
            for (int i =0;i< gridSepet.Rows.Count;i++)
                genelToplam += Convert.ToDecimal(gridSepet.Rows[i].Cells["Tutar"].Value);

            lblToplamTutar.Text = genelToplam.ToString("0.00")+"TL";
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            // KONTROLLER
            if (gridSepet.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş, satış yapılamaz!");
                return;
            }

            if (cmbMusteri.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.");
                return;
            }

            try
            {
                //Toplam Tutarı Tablodan Hesapla (Label'dan okumuyoruz!)
                decimal hesaplananToplam = 0;
                for (int i = 0; i < dtSepet.Rows.Count; i++)
                {
                    hesaplananToplam += Convert.ToDecimal(dtSepet.Rows[i]["Tutar"]);
                }

                //Satış Fişini Oluştur (Stored Procedure ile)
                SqlCommand komutBaslik = new SqlCommand("SP_SatisBaslat", bgl.Baglanti());
                komutBaslik.CommandType = CommandType.StoredProcedure;

                // Müşteri ID'sini alırken garanti yöntem (ToString sonra Parse)
                komutBaslik.Parameters.AddWithValue("@MusteriID", int.Parse(cmbMusteri.SelectedValue.ToString()));
                komutBaslik.Parameters.AddWithValue("@PersonelID", 1); // Admin
                komutBaslik.Parameters.AddWithValue("@ToplamTutar", hesaplananToplam); // Hesapladığımız temiz sayı

                // SP çalıştır ve yeni ID'yi al
                object sonuc = komutBaslik.ExecuteScalar();
                int yeniSatisID = Convert.ToInt32(sonuc);

                //Detayları Kaydet ve Stoğu Düş
                for (int i = 0; i < dtSepet.Rows.Count; i++)
                {
                    SqlCommand komutDetay = new SqlCommand("INSERT INTO SatisDetaylari (SatisID, IlacID, Adet, BirimFiyat, ToplamFiyat) VALUES (@p1, @p2, @p3, @p4, @p5)", bgl.Baglanti());

                    komutDetay.Parameters.AddWithValue("@p1", yeniSatisID);
                    komutDetay.Parameters.AddWithValue("@p2", Convert.ToInt32(dtSepet.Rows[i]["IlacID"]));
                    komutDetay.Parameters.AddWithValue("@p3", Convert.ToInt32(dtSepet.Rows[i]["Adet"]));
                    komutDetay.Parameters.AddWithValue("@p4", Convert.ToDecimal(dtSepet.Rows[i]["Fiyat"]));
                    komutDetay.Parameters.AddWithValue("@p5", Convert.ToDecimal(dtSepet.Rows[i]["Tutar"]));

                    komutDetay.ExecuteNonQuery();
                }

                bgl.Baglanti().Close();

                MessageBox.Show("Satış başarıyla tamamlandı! Fiş No: " + yeniSatisID);

                dtSepet.Clear();
                lblToplamTutar.Text = "0.00 TL";
                IlacGetir(""); // Stokları kontrol etmek için listeyi yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış Hatası: " + ex.Message);
                if (bgl.Baglanti().State == ConnectionState.Open)
                    bgl.Baglanti().Close();
            }
            IlacGetir("");
        }

        private void btnSepetEkle_Click(object sender, EventArgs e)
        {
            if (gridIlaclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen İlaç Seçimi Yapınız!");
                return;
            }
            int secilenIlacID = Convert.ToInt32(gridIlaclar.CurrentRow.Cells["IlacID"].Value); //string i inte çevirmeliyiz
            string ilacAdi = gridIlaclar.CurrentRow.Cells["IlacAd"].Value.ToString();
            decimal fiyat = Convert.ToDecimal(gridIlaclar.CurrentRow.Cells["Fiyat"].Value);
            int stok = Convert.ToInt32(gridIlaclar.CurrentRow.Cells["StokAdet"].Value);
            
            int adet = int.Parse(txtAdet.Text);

            if (adet > stok) //elde istenilen miktarda ürün var mı kontrolü yapma
            {
                MessageBox.Show("Yetersiz Stok bulunmakta! " + "Stokta " + stok + " adet var.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal toplamTutar = adet * fiyat;
            dtSepet.Rows.Add(secilenIlacID, ilacAdi, adet, fiyat, toplamTutar);
            gridSepet.DataSource = dtSepet;
            Stil.GridDuzenle(gridSepet);
            ToplamHesapla();
        }

        private void gridSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }
    }
}
