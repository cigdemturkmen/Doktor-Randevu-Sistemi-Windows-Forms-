
namespace DRS.UI
{
    partial class DoktorListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvwDoktorlar = new System.Windows.Forms.ListView();
            this.lviTCKN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviDogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviBrans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviMezunOlduguOkul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviUnvan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviIller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviIlce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYenile = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwDoktorlar
            // 
            this.lvwDoktorlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lviTCKN,
            this.lviAd,
            this.lviSoyad,
            this.lviDogumTarihi,
            this.lviCinsiyet,
            this.lviBrans,
            this.lviMezunOlduguOkul,
            this.lviUnvan,
            this.lviTelefon,
            this.lviIller,
            this.lviIlce,
            this.lviAdres});
            this.lvwDoktorlar.FullRowSelect = true;
            this.lvwDoktorlar.GridLines = true;
            this.lvwDoktorlar.HideSelection = false;
            this.lvwDoktorlar.Location = new System.Drawing.Point(0, 0);
            this.lvwDoktorlar.Name = "lvwDoktorlar";
            this.lvwDoktorlar.Size = new System.Drawing.Size(796, 409);
            this.lvwDoktorlar.TabIndex = 0;
            this.lvwDoktorlar.UseCompatibleStateImageBehavior = false;
            this.lvwDoktorlar.View = System.Windows.Forms.View.Details;
            // 
            // lviTCKN
            // 
            this.lviTCKN.Text = "TC Kimlik Numarası";
            // 
            // lviAd
            // 
            this.lviAd.Text = "Ad";
            // 
            // lviSoyad
            // 
            this.lviSoyad.Text = "Soyad";
            // 
            // lviDogumTarihi
            // 
            this.lviDogumTarihi.DisplayIndex = 4;
            this.lviDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lviCinsiyet
            // 
            this.lviCinsiyet.DisplayIndex = 3;
            this.lviCinsiyet.Text = "Cinsiyet";
            // 
            // lviBrans
            // 
            this.lviBrans.Text = "Brans";
            // 
            // lviMezunOlduguOkul
            // 
            this.lviMezunOlduguOkul.Text = "Mezuniyet";
            // 
            // lviUnvan
            // 
            this.lviUnvan.Text = "Unvan";
            // 
            // lviTelefon
            // 
            this.lviTelefon.Text = "Telefon";
            // 
            // lviIller
            // 
            this.lviIller.Text = "Şehir";
            // 
            // lviIlce
            // 
            this.lviIlce.Text = "İlçe";
            // 
            // lviAdres
            // 
            this.lviAdres.Text = "Adres";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(689, 415);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(107, 31);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // DoktorListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 490);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lvwDoktorlar);
            this.Name = "DoktorListesi";
            this.Text = "DoktorListesi";
            this.Load += new System.EventHandler(this.DoktorListesi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader lviTCKN;
        private System.Windows.Forms.ColumnHeader lviAd;
        private System.Windows.Forms.ColumnHeader lviSoyad;
        private System.Windows.Forms.ColumnHeader lviCinsiyet;
        private System.Windows.Forms.ColumnHeader lviDogumTarihi;
        private System.Windows.Forms.ColumnHeader lviBrans;
        private System.Windows.Forms.ColumnHeader lviMezunOlduguOkul;
        private System.Windows.Forms.ColumnHeader lviUnvan;
        private System.Windows.Forms.ColumnHeader lviTelefon;
        private System.Windows.Forms.ColumnHeader lviIller;
        private System.Windows.Forms.ColumnHeader lviIlce;
        private System.Windows.Forms.ColumnHeader lviAdres;
        public System.Windows.Forms.ListView lvwDoktorlar;
        public System.Windows.Forms.Button btnYenile;
    }
}