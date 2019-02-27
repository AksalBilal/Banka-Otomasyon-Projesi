namespace BankaOtomasyon
{
    partial class Form1
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
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaGelirGiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapDökümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1101, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriToolStripMenuItem,
            this.hesapEkleToolStripMenuItem,
            this.paraYatırmaToolStripMenuItem,
            this.paraÇekmeToolStripMenuItem,
            this.havaleToolStripMenuItem,
            this.hesapSilToolStripMenuItem});
            this.müşteriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.müşteriToolStripMenuItem.Text = "MÜŞTERİ";
            // 
            // yeniMüşteriToolStripMenuItem
            // 
            this.yeniMüşteriToolStripMenuItem.Name = "yeniMüşteriToolStripMenuItem";
            this.yeniMüşteriToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
            this.yeniMüşteriToolStripMenuItem.Text = "MÜŞTERİ EKLEME";
            this.yeniMüşteriToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşteriToolStripMenuItem_Click);
            // 
            // hesapEkleToolStripMenuItem
            // 
            this.hesapEkleToolStripMenuItem.Name = "hesapEkleToolStripMenuItem";
            this.hesapEkleToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
            this.hesapEkleToolStripMenuItem.Text = "HESAP EKLEME";
            this.hesapEkleToolStripMenuItem.Click += new System.EventHandler(this.hesapEkleToolStripMenuItem_Click);
            // 
            // paraYatırmaToolStripMenuItem
            // 
            this.paraYatırmaToolStripMenuItem.Name = "paraYatırmaToolStripMenuItem";
            this.paraYatırmaToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
            this.paraYatırmaToolStripMenuItem.Text = "PARA YATIRMA";
            this.paraYatırmaToolStripMenuItem.Click += new System.EventHandler(this.paraYatırmaToolStripMenuItem_Click);
            // 
            // paraÇekmeToolStripMenuItem
            // 
            this.paraÇekmeToolStripMenuItem.Name = "paraÇekmeToolStripMenuItem";
            this.paraÇekmeToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
            this.paraÇekmeToolStripMenuItem.Text = "PARA ÇEKME";
            this.paraÇekmeToolStripMenuItem.Click += new System.EventHandler(this.paraÇekmeToolStripMenuItem_Click);
            // 
            // havaleToolStripMenuItem
            // 
            this.havaleToolStripMenuItem.Name = "havaleToolStripMenuItem";
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
            this.havaleToolStripMenuItem.Text = "HAVALE";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // hesapSilToolStripMenuItem
            // 
            this.hesapSilToolStripMenuItem.Name = "hesapSilToolStripMenuItem";
            this.hesapSilToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
            this.hesapSilToolStripMenuItem.Text = "HESAP SİLME";
            this.hesapSilToolStripMenuItem.Click += new System.EventHandler(this.hesapSilToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankaGelirGiderToolStripMenuItem,
            this.hesapDökümüToolStripMenuItem});
            this.raporlarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.raporlarToolStripMenuItem.Text = "RAPORLAR";
            // 
            // bankaGelirGiderToolStripMenuItem
            // 
            this.bankaGelirGiderToolStripMenuItem.Name = "bankaGelirGiderToolStripMenuItem";
            this.bankaGelirGiderToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.bankaGelirGiderToolStripMenuItem.Text = "BANKA GELİR-GİDER RAPORU";
            this.bankaGelirGiderToolStripMenuItem.Click += new System.EventHandler(this.bankaGelirGiderToolStripMenuItem_Click);
            // 
            // hesapDökümüToolStripMenuItem
            // 
            this.hesapDökümüToolStripMenuItem.Name = "hesapDökümüToolStripMenuItem";
            this.hesapDökümüToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.hesapDökümüToolStripMenuItem.Text = "HESAP DÖKÜMÜ";
            this.hesapDökümüToolStripMenuItem.Click += new System.EventHandler(this.hesapDökümüToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 741);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BANKA OTOMASYON";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaGelirGiderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapDökümüToolStripMenuItem;
    }
}

