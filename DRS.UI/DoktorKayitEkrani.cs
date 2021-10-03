using DRS.Models.Entities;
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
    public partial class DoktorKayitEkrani : Form
    {
        List<Doktor> doktorlarListesi = null;
        public DoktorKayitEkrani()
        {
            InitializeComponent();
        }

        private void DoktorKayitEkrani_Load(object sender, EventArgs e)
        {
            doktorlarListesi = ((MainPage)this.MdiParent).doktorlar;  // Asla çözemedim. Her yerde aynı hata.

            //MainPage main = new MainPage();
            //var doktorListesi = main.doktorlar;

            mtxtTelefon.Mask = "\\+\\9\\0\\(000\\) 0000000";

            foreach (var item in Enum.GetValues(typeof(Models.Enums.Brans)))
            {
                cmbBrans.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(Models.Enums.Unvan)))
            {
                cmbUnvan.Items.Add(item);
            }

            var iller = new List<string> {"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};

            var ilceler = new List<string> { "Çankaya", "Keçiören", "Şahinbey", "Osmangazi", "Esenyurt", "Seyhan", "Küçükçekmece", "Şehitkamil", "Bağcılar", "Yenimahalle", "Ümraniye", "Pendik", "Kozaklı", "Selçuklu", "Mamak", "Bahçelievler", "Sincan", "Etimesgut", "Melikgazi", "Üsküdar", "Sultangazi", "Kepez", "Gaziosmanpaşa" };

            foreach (var il in iller)
            {
                cmbIller.Items.Add(il);
            }

            foreach (var ilce in ilceler)
            {
                cmbIlceler.Items.Add(ilce);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();

            doktor.Ad = txtAd.Text;
            doktor.Soyad = txtSoyad.Text;
            doktor.TCKN = mtxtTCKN.Text;
            doktor.DogumTarihi = dtpDogumTarihi.Value;
            doktor.Cinsiyet = (rdbErkek.Checked) ? Models.Enums.Cinsiyet.Erkek : Models.Enums.Cinsiyet.Kadin;
            doktor.Brans = (Models.Enums.Brans)cmbBrans.SelectedItem;
            doktor.MezunOlduguOkul = txtMezuniyet.Text;
            doktor.Unvan = (Models.Enums.Unvan)cmbBrans.SelectedItem;
            doktor.Telefon = mtxtTelefon.Text;
            doktor.Il = cmbIller.SelectedItem.ToString();
            doktor.Ilce = cmbIlceler.SelectedItem.ToString();
            doktor.Adres = txtAdres.Text;

            if (!doktorlarListesi.Exists(doctorX => doctorX.TCKN == doktor.TCKN))
            {
                doktorlarListesi.Add(doktor);
            }
            else
            {
                MessageBox.Show("Bu TC kimlik numarasına sahip bir doktor zaten mevcut.");
                return;
            }

            var secim = MessageBox.Show("Kayıt başarıyla oluşturuldu. Başka bir doktor kaydetmek istiyor musunuz", "Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (secim == DialogResult.Yes)
            {
                FormHelpers.FormuTemizle(this);
            }
            else
            {
                this.Close();
            }
        }
        
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormHelpers.FormuTemizle(this);
        }
    }
}
