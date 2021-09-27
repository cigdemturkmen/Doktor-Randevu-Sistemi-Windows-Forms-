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
            //uygulamayı kapat

            DialogResult cevap = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        //void FormlariDolas()
        //{
        //    foreach (Form item in Application.OpenForms)
        //    {
        //        if (item.Text == "HastaKayitEkrani")
        //        {
        //            hastaKayitEkrani = item;
        //        }
        //    }
        //}

        private void hastaKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hasta kayıt ekranı açtıracak
            //eğer mevcutta açık olan bir hasta kayıt ekranı varsa ön plana getir. yoksa yeni instance oluştur

            //Application.OpenForms -açık olan formlar

            Form hastaKayitEkrani = null;
            //açık olan fromlarda adı hastaKayitEkrani olan bir formu arıyoruz
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "HastaKayitEkrani")
                {
                    hastaKayitEkrani = item;
                }
            }

            //arama sonucuna göre daha önce açılmış ise null gelmez o yüzden öne getirme işlemi yapılır
            if (hastaKayitEkrani != null)
            {
                hastaKayitEkrani.BringToFront();
            }
            else
            {
                //eğer daha önce kayıt ekranı açılmışsa o zaman yeni instance oluşturup açarız
                hastaKayitEkrani = new HastaKayitEkrani();
                hastaKayitEkrani.MdiParent = this;
                hastaKayitEkrani.WindowState = FormWindowState.Maximized;
                hastaKayitEkrani.Show();
            }
                
            
        }

        private void hastaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hasta listesi ekranı açtıracak
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
                //eğer daha önce kayıt ekranı açılmışsa o zaman yeni instance oluşturup açarız
                hastaListesi = new HastaListesi();
                hastaListesi.MdiParent = this;
                hastaListesi.WindowState = FormWindowState.Maximized;
                hastaListesi.Show();
            }
        }
    }
}
