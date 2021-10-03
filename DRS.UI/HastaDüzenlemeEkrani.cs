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
    public partial class HastaDüzenlemeEkrani : Form
    {
        public List<string> iller = new List<string> {"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};

        public List<string> ilceler = new List<string> { "Çankaya", "Keçiören", "Şahinbey", "Osmangazi", "Esenyurt", "Seyhan", "Küçükçekmece", "Şehitkamil", "Bağcılar", "Yenimahalle", "Ümraniye", "Pendik", "Kozaklı", "Selçuklu", "Mamak", "Bahçelievler", "Sincan", "Etimesgut", "Melikgazi", "Üsküdar", "Sultangazi", "Kepez", "Gaziosmanpaşa" };

        public HastaDüzenlemeEkrani()
        {
            InitializeComponent();// constructorda listeyi alamıyorsunuz loadda yapmanız lazım????

            foreach (var il in iller)
            {
                cmbIller.Items.Add(il);
            }

            foreach (var ilce in ilceler)
            {
                cmbIlceler.Items.Add(ilce);
            }
        }

        private void HastaDüzenlemeEkrani_Load(object sender, EventArgs e)
        {
            mtxtTelefon.Mask = "\\+\\9\\0\\(000\\) 0000000";
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //hastalar listesindeki tckn'sine göre kişiyi getir ve bilgilerini düzenle

            var tc = mtxtTCKN.Text;

            var hastalarListesi = ((MainPage)this.MdiParent).hastalar;

            var duzenlenecekHasta = hastalarListesi.FirstOrDefault(x => x.TCKN == tc);

            if (duzenlenecekHasta != null)
            {
                duzenlenecekHasta.Ad = txtAd.Text;
                duzenlenecekHasta.Soyad = txtSoyad.Text;
                duzenlenecekHasta.Cinsiyet = rdbErkek.Checked ? Models.Enums.Cinsiyet.Erkek : Models.Enums.Cinsiyet.Kadin;
                duzenlenecekHasta.Kilo = Convert.ToDouble(upDownKilo.Value);
                duzenlenecekHasta.Boy = Convert.ToDouble(upDownBoy.Value);
                duzenlenecekHasta.DogumTarihi = dtpDogumTarihi.Value;
                duzenlenecekHasta.Telefon = mtxtTelefon.Text;
                duzenlenecekHasta.Il = cmbIller.SelectedItem.ToString();
                duzenlenecekHasta.Ilce = cmbIlceler.SelectedItem.ToString();
                duzenlenecekHasta.Adres = txtAdres.Text;

            }
        }
    }
}
