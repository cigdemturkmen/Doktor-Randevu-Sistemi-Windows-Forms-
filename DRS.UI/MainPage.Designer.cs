
namespace DRS.UI
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorKayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuKayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaToolStripMenuItem,
            this.doktorİşlemleriToolStripMenuItem,
            this.randevuİşlemleriToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayitToolStripMenuItem,
            this.hastaListesiToolStripMenuItem});
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.hastaToolStripMenuItem.Text = "Hasta İşlemleri";
            // 
            // hastaKayitToolStripMenuItem
            // 
            this.hastaKayitToolStripMenuItem.Name = "hastaKayitToolStripMenuItem";
            this.hastaKayitToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.hastaKayitToolStripMenuItem.Text = "Hasta Kayıt";
            this.hastaKayitToolStripMenuItem.Click += new System.EventHandler(this.hastaKayitToolStripMenuItem_Click);
            // 
            // hastaListesiToolStripMenuItem
            // 
            this.hastaListesiToolStripMenuItem.Name = "hastaListesiToolStripMenuItem";
            this.hastaListesiToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.hastaListesiToolStripMenuItem.Text = "Hasta Listesi";
            this.hastaListesiToolStripMenuItem.Click += new System.EventHandler(this.hastaListesiToolStripMenuItem_Click);
            // 
            // doktorİşlemleriToolStripMenuItem
            // 
            this.doktorİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorKayitToolStripMenuItem,
            this.doktorListesiToolStripMenuItem});
            this.doktorİşlemleriToolStripMenuItem.Name = "doktorİşlemleriToolStripMenuItem";
            this.doktorİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.doktorİşlemleriToolStripMenuItem.Text = "Doktor İşlemleri";
            // 
            // doktorKayitToolStripMenuItem
            // 
            this.doktorKayitToolStripMenuItem.Name = "doktorKayitToolStripMenuItem";
            this.doktorKayitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.doktorKayitToolStripMenuItem.Text = "Doktor Kayıt";
            this.doktorKayitToolStripMenuItem.Click += new System.EventHandler(this.doktorKayitToolStripMenuItem_Click);
            // 
            // doktorListesiToolStripMenuItem
            // 
            this.doktorListesiToolStripMenuItem.Name = "doktorListesiToolStripMenuItem";
            this.doktorListesiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.doktorListesiToolStripMenuItem.Text = "Doktor Listesi";
            this.doktorListesiToolStripMenuItem.Click += new System.EventHandler(this.doktorListesiToolStripMenuItem_Click);
            // 
            // randevuİşlemleriToolStripMenuItem
            // 
            this.randevuİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuKayitToolStripMenuItem,
            this.randevuListesiToolStripMenuItem});
            this.randevuİşlemleriToolStripMenuItem.Name = "randevuİşlemleriToolStripMenuItem";
            this.randevuİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.randevuİşlemleriToolStripMenuItem.Text = "Randevu İşlemleri";
            // 
            // randevuKayitToolStripMenuItem
            // 
            this.randevuKayitToolStripMenuItem.Name = "randevuKayitToolStripMenuItem";
            this.randevuKayitToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.randevuKayitToolStripMenuItem.Text = "Randevu Kayıt";
            // 
            // randevuListesiToolStripMenuItem
            // 
            this.randevuListesiToolStripMenuItem.Name = "randevuListesiToolStripMenuItem";
            this.randevuListesiToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.randevuListesiToolStripMenuItem.Text = "Randevu Listesi";
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorKayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuKayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
    }
}