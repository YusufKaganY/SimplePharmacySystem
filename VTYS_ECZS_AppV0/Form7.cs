using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VTYS_ECZS_AppV0
{
    public partial class Form7 : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        DataTable dt = new DataTable(); // Arama yapabilmek için tabloyu global oldu

        public Form7()
        {
            InitializeComponent();

            Stil.FormDuzenle(this);
            this.Text = "Log Kayıtları";

            LoglariListele();
            PersonelCiroListele();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Stil.GridDuzenle(gridLoglar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void LoglariListele()
        {
            try
            {
                if (gridLoglar == null) return;

                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SistemLoglari ORDER BY Tarih DESC", bgl.Baglanti());
                da.Fill(dt);

                gridLoglar.AutoGenerateColumns = true;
                gridLoglar.DataSource = dt;
                Stil.GridDuzenle(gridLoglar);

                // Sütun varsa işlem yap, yoksa pas geç (Hata vermez)

                if (gridLoglar.Columns.Contains("LogID"))
                    gridLoglar.Columns["LogID"].Visible = false;

                if (gridLoglar.Columns.Contains("IslemTipi"))
                    gridLoglar.Columns["IslemTipi"].HeaderText = "İşlem Türü";

                if (gridLoglar.Columns.Contains("Aciklama"))
                {
                    gridLoglar.Columns["Aciklama"].HeaderText = "Detaylı Açıklama";
                    //gridLoglar.Columns["Aciklama"].MinimumWidth = 400;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;

            DataView dv = dt.DefaultView;
            // Artık Açıklama veya İşlem Tipi içinde arama yapıyoruz
            dv.RowFilter = string.Format("Aciklama LIKE '%{0}%' OR IslemTipi LIKE '%{0}%'", txtArama.Text);

            gridLoglar.DataSource = dv;
        }

        void PersonelCiroListele()
        {
            try
            {
                DataTable dtP = new DataTable();

                // Her personelin adını ve fonksiyonun hesapladığı ciroyu getiriyoruz.
                string sql = "select AdSoyad, dbo.fn_PersonelToplamSatis(PersonelID) AS [Toplam Ciro] FROM Personeller";

                SqlDataAdapter da = new SqlDataAdapter(sql, bgl.Baglanti());
                da.Fill(dtP);

                gridPersonel.DataSource = dtP;
                gridPersonel.AutoGenerateColumns = true;
                Stil.GridDuzenle(gridPersonel);

                // Para birimi gibi görünsün diye format
                if (gridPersonel.Columns.Contains("Toplam Ciro"))
                {
                    gridPersonel.Columns["Toplam Ciro"].DefaultCellStyle.Format = "C2"; // TL simgesi koyar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel Tablosu Hatası: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}