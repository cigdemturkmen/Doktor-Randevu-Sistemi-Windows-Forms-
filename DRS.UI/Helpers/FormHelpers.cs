using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRS.UI.Helpers
{
    public static class FormHelpers
    {
        
        public static void FormuTemizle(Form TemizlenecekForm)
        {
            // FORMU TEMİZLE

            foreach (var control in TemizlenecekForm.Controls)
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
                if (control is GroupBox)
                {
                    var grpBox = (GroupBox)control;
                    foreach (var item in grpBox.Controls)
                    {
                        if (item is RadioButton)
                        {
                            var rdb = (RadioButton)item;
                            rdb.Checked = false;
                        }
                    }
                }
            }
        }
     
        public static void EkranActirma(string formName, Form x)
        {
            // KONTROLLÜ EKRAN AÇTIR

            Form ekran = null;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == formName)
                {
                    ekran = item;
                }
            }

            if (ekran != null)
            {
                ekran.BringToFront();
            }
            else
            { 
                //var masterOfTheApplication = (MainPage)x.MdiParent;
                //x.MdiParent = x.MdiParent; 
                x.WindowState = FormWindowState.Maximized;
                x.Show();
            }
        }

        public static void ListeyiYenile(Form x)
        {
            // LİSTEYİ YENİLE/DOLDUR

            //var hastaListesi = ((MainPage)x.MdiParent).hastalar;

            MainPage main = new MainPage();

            var hastaListesi = main.hastalar;

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

                foreach (var control in x.Controls)
                {
                    if (control is ListView)
                    {
                        var lvi = (ListView)control;
                        lvi.Items.Add(li);
                    }
                }
                
            }
        } // ListeyiDoldur
    }
}
