using DRS.Models.Entities;
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
        public HastaKayitEkrani()
        {
            InitializeComponent();
        }

        // Formu temizlemek için fonksiyon
        void FormuTemizle()
        {
            foreach (var control in this.Controls)
            {

                if (control is TextBox)
                {
                    var text = (TextBox)control;
                    text.Text = "";
                }
                else if (control is MaskedTextBox)
                {
                    var text = (MaskedTextBox)control;
                    text.Text = "";
                }
                else if (control is DateTimePicker)
                {
                    var dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
                else if (control is RadioButton)
                {
                    var rbutton = (RadioButton)control;
                    rbutton.Checked = false; // bu çalışmadı sonra bakacağım.
                }
                else if (control is NumericUpDown)
                {
                    var numUpDown = (NumericUpDown)control;
                    numUpDown.Value = 0;
                }
                else if (control is ComboBox)
                {
                    var cmb = (ComboBox)control;
                    cmb.SelectedIndex = -1;
                }
            }
        }

        // Form'un load'unda gelecek mask'ler ve ComboBox item'ları.
        private void HastaKayitEkrani_Load(object sender, EventArgs e)
        {
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

            foreach (var il in iller)
            {
                cmbIller.Items.Add(il);
            }

            var ilceler = new List<string> { "Çankaya", "Keçiören", "Şahinbey", "Osmangazi", "Esenyurt", "Seyhan", "Küçükçekmece", "Şehitkamil", "Bağcılar", "Yenimahalle", "Ümraniye", "Pendik", "Kozaklı", "Selçuklu", "Mamak", "Bahçelievler", "Sincan", "Etimesgut", "Melikgazi", "Üsküdar", "Sultangazi", "Kepez", "Gaziosmanpaşa" };

            foreach (var ilce in ilceler)
            {
                cmbIlceler.Items.Add(ilce);
            }
        }

        
        // Hasta kaydetme butonu
        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            var hasta = new Hasta();

            hasta.Ad = txtAd.Text;
            hasta.Soyad = txtSoyad.Text;
            hasta.TCKN = mtxtTCKN.Text;
            hasta.DogumTarihi = dtpDogumTarihi.Value;
            if (rdbErkek.Checked)
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

            List<Hasta> hastalar = new List<Hasta>();

            hastalar.Add(hasta);

        }

        // Temizle butonu
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
    }
}
