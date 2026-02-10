using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_ECZS_AppV0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIlaclar_Click(object sender, EventArgs e)
        {
            //ilaclari form3 de listeleme
            Form3 ilaclar = new Form3();
            ilaclar.Show();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            Form4 satisEkrani = new Form4();
            satisEkrani.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Form5 musteriler = new Form5();
            musteriler.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Form6 raporlar = new Form6();
            raporlar.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = "Aktif Personel: " + Program.GirisYapanAdSoyad + "  (ID: " + Program.GirisYapanID + ")";
        
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoglar_Click(object sender, EventArgs e)
        {
            Form7 logEkrani = new Form7();
            logEkrani.Show();
        }
    }
}