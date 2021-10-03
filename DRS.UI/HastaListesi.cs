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
    public partial class HastaListesi : Form
    {
        List<Hasta> hastaListesi = null;
        
        public HastaListesi()
        {
            InitializeComponent(); 
            // constructorda listeyi alamıyorsunuz loadda yapmanız lazım.
        }
        
        private void HastaListesi_Load(object sender, EventArgs e)
        {
            hastaListesi = ((MainPage)this.MdiParent).hastalar; // bu kod sürekli hata patlatıyor

            foreach (var item in hastaListesi)
            {

                ListViewItem li = new ListViewItem(item.TCKN); // ilk kolondaki değer
                li.SubItems.Add(item.Ad);
                li.SubItems.Add(item.Soyad);
                li.SubItems.Add(item.Cinsiyet.ToString());
                li.SubItems.Add(item.DogumTarihi.ToString("dd/MM/yyyy"));
                li.SubItems.Add(item.Boy.ToString());
                li.SubItems.Add(item.Kilo.ToString());
                li.SubItems.Add(item.Telefon);
                li.SubItems.Add(item.Il);
                li.SubItems.Add(item.Ilce);
                li.SubItems.Add(item.Adres);

                listView1.Items.Add(li);
            }
        }

        
        private void btnYenile_Click(object sender, EventArgs e)
        {
            FormHelpers.ListeyiYenile(this);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hastalar listesinden bu kişiyi bulup sildirin.
            hastaListesi = ((MainPage)this.MdiParent).hastalar;

            var secilenHastaninTcNumarasi = listView1.SelectedItems[0].Text; // index[0] seçilen satırlardan ilki demek.

            var secilenHasta = hastaListesi.FirstOrDefault(XmlReadMode => XmlReadMode.TCKN == secilenHastaninTcNumarasi);

            if (secilenHasta != null)
            {
                hastaListesi.Remove(secilenHasta);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // seçilen elemanı alıp ekrandaki gerekli alanları doldurmak.(ekleme ekranı da eklenebilir ama biz yapmıcaz.yaptık)
            //hasta düzenleme ekranı

            hastaListesi = ((MainPage)this.MdiParent).hastalar;
            var secilenElemanınTcNo = listView1.SelectedItems[0].Text;

            var secilenHasta = hastaListesi.FirstOrDefault(x => x.TCKN == secilenElemanınTcNo);

            if (secilenHasta != null)
            {
                HastaDüzenlemeEkrani hastaDüzenlemeEkrani = new HastaDüzenlemeEkrani();
                hastaDüzenlemeEkrani.WindowState = FormWindowState.Maximized;
                hastaDüzenlemeEkrani.MdiParent = this.MdiParent;
                hastaDüzenlemeEkrani.Name = "HastaDüzenlemeEkrani";

                hastaDüzenlemeEkrani.txtAd.Text = secilenHasta.Ad;
                hastaDüzenlemeEkrani.txtSoyad.Text = secilenHasta.Soyad;
                hastaDüzenlemeEkrani.mtxtTCKN.Text = secilenHasta.TCKN;
                hastaDüzenlemeEkrani.dtpDogumTarihi.Value = secilenHasta.DogumTarihi;
                if (secilenHasta.Cinsiyet == Models.Enums.Cinsiyet.Erkek)
                {
                    hastaDüzenlemeEkrani.rdbErkek.Checked = true;
                }
                else
                {
                    hastaDüzenlemeEkrani.rdbKadin.Checked = true;
                }
                //hastaDüzenlemeEkrani.upDownBoy = secilenHasta.Boy;
                //hastaDüzenlemeEkrani.upDownKilo = secilenHasta.Kilo;
                //hastaDüzenlemeEkrani.mtxtTelefon = secilenHasta.Telefon;
                //hastaDüzenlemeEkrani.cmbIller.SelectedItem = secilenHasta.Il; //buranın hasta düzenleme ekranının loadına illa ki mask ve iller ilceler eklenecek.
                //hastaDüzenlemeEkrani.cmbIlceler.SelectedIndex = ilceler.IndexOf(secilenHasta.Ilce);//alternatif seçenek!!! index ile seçim arama
                //hastaDüzenlemeEkrani.txtAdres = secilenHasta.Adres;

                hastaDüzenlemeEkrani.Show();

            }
        }
    }
}
