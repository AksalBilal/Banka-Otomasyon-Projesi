namespace BankaOtomasyon
{
    partial class frmHesapAc
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
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(271, 81);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(119, 22);
            this.txtMusteriNo.TabIndex = 0;
            this.txtMusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(80, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Musteri Numarası";
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHesapAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnHesapAc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHesapAc.Location = new System.Drawing.Point(53, 151);
            this.btnHesapAc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(169, 78);
            this.btnHesapAc.TabIndex = 2;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = false;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 259);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 194);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnYenile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnYenile.Location = new System.Drawing.Point(271, 151);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(160, 78);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Kayıt Defteri Güncelle";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankaOtomasyon.Properties.Resources.unnamed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(489, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 199);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmHesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(848, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMusteriNo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHesapAc";
            this.Text = "HESAP AÇMA";
            this.Load += new System.EventHandler(this.frmHesapAc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}