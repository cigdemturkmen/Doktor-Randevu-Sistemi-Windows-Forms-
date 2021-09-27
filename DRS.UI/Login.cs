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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = txtKullaniciAdi.Text.ToLower();
            var sifre = txtSifre.Text;

            if (kullaniciAdi != "admin" || sifre != "1234")
            {
                MessageBox.Show("Bilgileriniz hatalı!");
            }
            else if (kullaniciAdi == "admin" && sifre == "1234" )
            {
                //MessageBox.Show("Giriş başarılı");
                //yeni ekran aç
                var anasayfaEkrani = new MainPage();
                anasayfaEkrani.Show();
                anasayfaEkrani.WindowState = FormWindowState.Maximized;

                //this.Close(); tüm pencereler kapanıyor. Loginde close deyince proje kapanıyor.
                this.Hide();
            }
            
        }
    }
}
