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
    public partial class Form6 : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();

        public Form6()
        {
            InitializeComponent();
            Stil.FormDuzenle(this);
            Stil.GridDuzenle(gridRapor);
            RaporuGetir();
            IstatikleriGetir();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        void RaporuGetir()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Vw_SatisRaporu",bgl.Baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridRapor.DataSource = dt;
                Stil.GridDuzenle(gridRapor);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: "+ex.Message);
            }
        }

        void IstatikleriGetir()
        {
            try
            {
                //gunluk ciro fonk
                SqlCommand komutCiro = new SqlCommand("select dbo.Fn_GunlukCiro(GETDATE())", bgl.Baglanti());
                object ciroSonuc = komutCiro.ExecuteScalar();
                decimal gunlukCiro = 0;
                if (ciroSonuc != DBNull.Value)//db de bos degilse sayıya cevirir
                {
                    gunlukCiro = Convert.ToDecimal(ciroSonuc);
                }
                lblCiro.Text = Convert.ToDecimal(ciroSonuc).ToString("C2");//c2 TL para birimi formatı (!)



                //toplam satis
                SqlCommand komutSayi = new SqlCommand("select COUNT(*) from Satislar",bgl.Baglanti());
                lblSatisSayisi.Text = komutSayi.ExecuteScalar().ToString();

                //KDV li Fiyat fonk - once 100 tl icin hesaplanacak sonra anlik hesaba gore
                SqlCommand komutKDV = new SqlCommand("SELECT dbo.Fn_KDVHesapla(@Deger)", bgl.Baglanti());
                komutKDV.Parameters.AddWithValue("@Deger", gunlukCiro);

                object kdvSonuc = komutKDV.ExecuteScalar();
                lblKDV.Text = Convert.ToDecimal(kdvSonuc).ToString("C2");

                bgl.Baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void gridRapor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
