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
    public partial class DoktorListesi : Form
    {
        List<Doktor> doktorlarListesi = null;
        public DoktorListesi()
        {
            InitializeComponent();
        }

        List<Doktor> doktorListesi = null; 

        private void DoktorListesi_Load(object sender, EventArgs e)
        {
            doktorlarListesi = ((MainPage)this.MdiParent).doktorlar;

            foreach (var item in doktorListesi)
            {
                ListViewItem lvi = new ListViewItem(item.TCKN);

                lvi.SubItems.Add(item.Ad);
                lvi.SubItems.Add(item.Soyad);
                lvi.SubItems.Add(item.DogumTarihi.ToString());
                lvi.SubItems.Add(item.Cinsiyet.ToString());
                lvi.SubItems.Add(item.Brans.ToString());
                lvi.SubItems.Add(item.MezunOlduguOkul);
                lvi.SubItems.Add(item.Unvan.ToString());
                lvi.SubItems.Add(item.Telefon);
                lvi.SubItems.Add(item.Il);
                lvi.SubItems.Add(item.Ilce);
                lvi.SubItems.Add(item.Adres);
            }
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            FormHelpers.ListeyiYenile(this);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelpers.EkranActirma("DoktorDuzenlemeEkrani", new DoktorDuzenlemeEkrani());
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenDoktorTC = lvwDoktorlar.SelectedItems[0].Text;

             var secilenDoktor = doktorListesi.FirstOrDefault(XmlReadMode => XmlReadMode.TCKN == secilenDoktorTC);

            if (secilenDoktor != null)
            {
                doktorListesi.Remove(secilenDoktor);
            }
        }
    }
}
