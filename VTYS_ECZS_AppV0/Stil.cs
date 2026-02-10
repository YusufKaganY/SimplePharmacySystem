using System.Drawing;
using System.Windows.Forms;

namespace VTYS_ECZS_AppV0
{
    public class Stil
    {
        //TABLOLARI GÜZELLEŞTİRME METODU
        public static void GridDuzenle(DataGridView grid)
        {
            grid.ReadOnly = true; // Hücrenin içine yazı yazılmasını engeller (Sadece seçilebilir yapar)
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tıklayınca TÜM SATIRI seçer
            grid.MultiSelect = false; // Aynı anda birden fazla satır seçilmesin (Karmaşayı önler)
            grid.AllowUserToAddRows = false; // En alttaki boş satırı kaldırır
            grid.AllowUserToDeleteRows = false; // Delete tuşuyla silmeyi engeller

            // Genel Ayarlar
            grid.BackgroundColor = Color.WhiteSmoke; // Hafif gri arka plan
            grid.BorderStyle = BorderStyle.Fixed3D;  // Çerçeve geri geldi

            // Izgara Çizgileri (Okunabilirlik için)
            grid.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Her hücrenin çevresi çizilsin
            grid.GridColor = Color.LightGray; // Çizgiler gri olsun (Beyaz değil)

            // Başlık Ayarları (Header)
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 52, 54); // Koyu Antrasit
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Yazı büyüdü
            grid.ColumnHeadersHeight = 45; // Başlık yükseldi

            // Satır Ayarları
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 184, 148); // Seçilince Parlak Yeşil
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10); // Satır yazıları büyüdü
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.BackColor = Color.White; // Normal satır beyaz

            grid.RowTemplate.Height = 35; // Satırlar daha geniş, ferah
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ekrana yay
            grid.RowHeadersVisible = false; // Sol baştaki boş gri kutuyu gizle
        }

        //FORMLARI STANDARTLAŞTIRMA METODU
        public static void FormDuzenle(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterScreen; // Ekranın ortasında başla
            frm.Size = new Size(1300, 700); // HEPSİ BU BOYUTTA OLACAK
            frm.FormBorderStyle = FormBorderStyle.FixedSingle; // Kenarlardan çekiştirip bozamasınlar
            frm.MaximizeBox = false; // Tam ekran yapmayı kapat (Tasarım bozulmasın diye)
            //frm.Text = "Eczane Otomasyon Sistemi"; // Pencere başlığı

            // Arka plan rengini de standart yapalım (Açık Gri)
            frm.BackColor = Color.FromArgb(236, 240, 241);
        }
    }
}