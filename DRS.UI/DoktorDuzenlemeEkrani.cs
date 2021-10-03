using DRS.Models.Enums;
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
    public partial class DoktorDuzenlemeEkrani : Form
    {
        public DoktorDuzenlemeEkrani()
        {
            InitializeComponent();
        }

        private void DoktorDuzenlemeEkrani_Load(object sender, EventArgs e)
        {
            mtxtTelefon.Mask = "\\+\\9\\0\\(000\\) 0000000";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var tc = mtxtTCKN.Text;

            var doktorlarListesi = ((MainPage)this.MdiParent).doktorlar;

            var duzenlenecekDoktor = doktorlarListesi.FirstOrDefault(x => x.TCKN == tc);

            if (duzenlenecekDoktor != null)
            {
                duzenlenecekDoktor.Ad = txtAd.Text;
                duzenlenecekDoktor.Soyad = txtSoyad.Text;
                duzenlenecekDoktor.DogumTarihi = dtpDogumTarihi.Value;
                duzenlenecekDoktor.Cinsiyet = rdbErkek.Checked ? Models.Enums.Cinsiyet.Erkek : Models.Enums.Cinsiyet.Kadin;

                var secilenBrans = cmbBrans.SelectedItem.ToString();
                var secilenBransEnumi = (Brans)Enum.Parse(typeof(Brans), secilenBrans);
                duzenlenecekDoktor.Brans = secilenBransEnumi;

                duzenlenecekDoktor.MezunOlduguOkul = txtMezuniyet.Text;

                var secilenUnvan = cmbUnvan.SelectedItem.ToString();
                var secilenUnvanEnumi = (Unvan)Enum.Parse(typeof(Brans), secilenUnvan);
                duzenlenecekDoktor.Unvan = secilenUnvanEnumi;

                duzenlenecekDoktor.Telefon = mtxtTelefon.Text;  
                duzenlenecekDoktor.Il = cmbIller.SelectedItem.ToString();
                duzenlenecekDoktor.Ilce = cmbIlceler.SelectedItem.ToString();
                duzenlenecekDoktor.Adres = txtAdres.Text;
            }
        }
    }
}
