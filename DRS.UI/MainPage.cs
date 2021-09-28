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
        public MainPage()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MenuStrip'te Çıkış seçeneğine tıklandığında uygulamayı kapat. Burada MessageBox'ın başka bir overload'ını kullandık.

            DialogResult cevap = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Ekran açık/kapalı kontrolü için metot. (Malesef çağıramıyorum)  :(
        public void EkranActirma(string formName, Form x)
        {
            Form hastakayitekrani = null;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == formName)
                {
                    hastakayitekrani = item;
                }
            }

            if (hastakayitekrani != null)
            {
                hastakayitekrani.BringToFront();
            }
            else
            {
                x.MdiParent = this;
                x.WindowState = FormWindowState.Maximized;
                x.Show();
            }
        }


        private void hastaKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MenuStrip'te Hasta Kayıt'a tıklandığında hasta kayıt formunu açtıracak.

            //Eğer mevcutta açık olan bir hasta kayıt ekranı varsa ön plana getir. Yoksa yeni instance oluştur. Bu kontrolü, tekrar tekrar aynı form açılmasın diye yapacağız(birden fazla instance oluşmasın diye)
            // Application.OpenForms -> açık olan formları temsil eder.




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
            EkranActirma("HastaKayitEkrani", new HastaKayitEkrani());

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
        }


        private void hastaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hasta listesi ekranı açtıracak
            Form hastaListesi = null;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "HastaListesi")
                {
                    hastaListesi = item;
                }
            }

            if (hastaListesi != null)
            {
                hastaListesi.BringToFront();
            }
            else
            {
                // Eğer daha önce kayıt ekranı açılmışsa o zaman yeni instance oluşturup açarız
                hastaListesi = new HastaListesi();
                hastaListesi.MdiParent = this;
                hastaListesi.WindowState = FormWindowState.Maximized;
                hastaListesi.Show();
            }

        }
    }
}

