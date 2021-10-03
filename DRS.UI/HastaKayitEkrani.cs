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
    public partial class HastaKayitEkrani : Form
    {
        List<Hasta> hastalarListesi = null;

        public HastaKayitEkrani()
        {
            InitializeComponent();
        }

        private void HastaKayitEkrani_Load(object sender, EventArgs e)
        {
            hastalarListesi = ((MainPage)this.MdiParent).hastalar; 
            //MainPage main = new MainPage();
            //var hastalarListesi = main.hastalar;


            // var buFormunMainFormu = (MainPage)this.MdiParent; // NEW'LEMEK RAMDA YER TUTMASIN DİYE BU YÖNTEMİ KULLANDIK.
            //var hastalarListesi = ((MainPage)this.MdiParent).hastalar; // Bu constroctorda çalışmıyor. O YÜZDEN LOADDa. Main page'de tanımladığımız List<Hasta>'yı getirir.

            mtxtTelefon.Mask = "\\+\\9\\0\\(000\\) 0000000";

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

        //List<Hasta> hastalarListesi = new List<Hasta>(); //buton her bastığında yeni instance oluşmasın diye globale aldık

        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            var hasta = new Hasta();

            hasta.Ad = txtAd.Text;
            hasta.Soyad = txtSoyad.Text;
            hasta.TCKN = mtxtTCKN.Text;
            hasta.DogumTarihi = dtpDogumTarihi.Value;
            if (rdbErkek.Checked) //ternary if'le yazılabilir.
            {
                hasta.Cinsiyet = Models.Enums.Cinsiyet.Erkek;
            }
            else if (rdbKadin.Checked)
            {
                hasta.Cinsiyet = Models.Enums.Cinsiyet.Kadin;
            }
            hasta.Boy = Convert.ToDouble(upDownBoy.Value);
            hasta.Kilo = Convert.ToDouble(upDownKilo.Value);
            hasta.Telefon = mtxtTelefon.Text;
            hasta.Il = cmbIller.SelectedItem.ToString();
            hasta.Ilce = cmbIlceler.SelectedItem.ToString();
            hasta.Adres = txtAdres.Text;


            // TCKN kontrolü yap.
            if (!hastalarListesi.Exists(x => x.TCKN == hasta.TCKN))
            {
                hastalarListesi.Add(hasta);
                MessageBox.Show("Hasta başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Bu TC kimlik numarası ile kayıtlı bir hasta zaten kayıtlı.");
                return;
            }

            var sonuc = MessageBox.Show("Yeni hasta kaydı oluşturmak istiyor musunuz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
               FormHelpers.FormuTemizle(this);
            }
            else
            {
                // Formu kapat
                this.Close();
            }
        }


        // Kaydedilen hastayı HastalarListesi formunda göster.
        // public HastaListesi liste = new HastaListesi();


        // Formu Temizler
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormHelpers.FormuTemizle(this);
        }
    }
}




