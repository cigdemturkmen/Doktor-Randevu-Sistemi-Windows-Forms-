using DRS.Models.Entities;
using DRS.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRS.UI
{
    public partial class MainPage : Form
    {
        public List<Hasta> hastalar = new List<Hasta>();
        public List<Doktor> doktorlar = new List<Doktor>();

        public MainPage()
        {
            InitializeComponent();
        }

        // Hasta Kayıt ekranını açar.
        private void hastaKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MenuStrip'te Hasta Kayıt'a tıklandığında hasta kayıt formunu açtıracak.
            // Eğer mevcutta açık olan bir hasta kayıt ekranı varsa ön plana getir. Yoksa yeni instance oluştur. Bu kontrolü, tekrar tekrar aynı form açılmasın diye yapacağız(birden fazla instance oluşmasın diye)
            // Application.OpenForms -> açık olan formları temsil eder.

            FormHelpers.EkranActirma("HastaKayitEkrani", new HastaKayitEkrani());


            #region MyAltCode
            //foreach (Form item in Application.OpenForms) // break koyunca neden çalışmıyor?
            //{
            //    if (item.Name == "HastaKayitEkrani")
            //    {
            //        item.BringToFront();
            //    }
            //    else if (item.Name != "HastaKayitEkrani")
            //    {
            //        var hastaKayitEkrani = new HastaKayitEkrani();
            //        hastaKayitEkrani.MdiParent = this;
            //        hastaKayitEkrani.WindowState = FormWindowState.Maximized;
            //        hastaKayitEkrani.Show();
            //    }
            //    break;
            //}



            /* Hocanın yazdığı açık/kapalı-kontrolü kodu aşağıda*/

            //Form hastaKayitEkrani = null;

            // Açık olan fromlarda adı hastaKayitEkrani olan bir formu arıyoruz
            //foreach (Form item in Application.OpenForms)
            //{
            //    if (item.Name == "HastaKayitEkrani")
            //    {
            //        hastaKayitEkrani = item;
            //    }
            //}

            //// Arama sonucuna göre daha önce açılmış ise null gelmez o yüzden öne getirme işlemi yapılır
            //if (hastaKayitEkrani != null)
            //{
            //    hastaKayitEkrani.BringToFront();
            //}
            //else
            //{
            //    // Eğer daha önce kayıt ekranı açılmamışsa o zaman yeni instance oluşturup açarız
            //    hastaKayitEkrani = new HastaKayitEkrani();
            //    hastaKayitEkrani.MdiParent = this;
            //    hastaKayitEkrani.WindowState = FormWindowState.Maximized;
            //    hastaKayitEkrani.Show();
            //} 
            #endregion
        }

        // Hasta Listesi ekranını açar.
        private void hastaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelpers.EkranActirma("HastaListesi", new HastaListesi());


            #region MyAltCode
            //Form hastaListesi = null;

            //foreach (Form item in Application.OpenForms)
            //{
            //    if (item.Text == "HastaListesi")
            //    {
            //        hastaListesi = item;
            //    }
            //}

            //if (hastaListesi != null)
            //{
            //    hastaListesi.BringToFront();
            //}
            //else
            //{
            //    // Eğer daha önce kayıt ekranı açılmışsa o zaman yeni instance oluşturup açarız
            //    hastaListesi = new HastaListesi();
            //    hastaListesi.MdiParent = this;
            //    hastaListesi.WindowState = FormWindowState.Maximized;
            //    hastaListesi.Show();
            //}
            #endregion
        }

        // Doktor Kayıt ekranını açar.
        private void doktorKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelpers.EkranActirma("DoktorKayitEkrani", new DoktorKayitEkrani());
        }

        // Doktor listesi ekranını açar.
        private void doktorListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelpers.EkranActirma("DoktorListesi", new DoktorListesi());
        }

        // Uygulamadan Çıkış
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

