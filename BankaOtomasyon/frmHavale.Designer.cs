namespace BankaOtomasyon
{
    partial class frmHavale
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGonderenHesap = new System.Windows.Forms.TextBox();
            this.txtAlanHesap = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Havle Yapacak Olan Hesap Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Havale Yapılacak Olan Hesap Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(25, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gönderilecek Tutar";
            // 
            // txtGonderenHesap
            // 
            this.txtGonderenHesap.Location = new System.Drawing.Point(354, 63);
            this.txtGonderenHesap.Margin = new System.Windows.Forms.Padding(4);
            this.txtGonderenHesap.Name = "txtGonderenHesap";
            this.txtGonderenHesap.Size = new System.Drawing.Size(132, 22);
            this.txtGonderenHesap.TabIndex = 3;
            this.txtGonderenHesap.TextChanged += new System.EventHandler(this.txtGonderenHesap_TextChanged);
            this.txtGonderenHesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGonderenHesap_KeyPress);
            // 
            // txtAlanHesap
            // 
            this.txtAlanHesap.Location = new System.Drawing.Point(354, 111);
            this.txtAlanHesap.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlanHesap.Name = "txtAlanHesap";
            this.txtAlanHesap.Size = new System.Drawing.Size(132, 22);
            this.txtAlanHesap.TabIndex = 4;
            this.txtAlanHesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlanHesap_KeyPress);
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(354, 162);
            this.txtPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(132, 22);
            this.txtPara.TabIndex = 5;
            this.txtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlanHesap_KeyPress);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnGonder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGonder.Location = new System.Drawing.Point(152, 222);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(190, 94);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Parayı Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(24, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Not:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(80, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bireysel Hesaplardan %2 gönderim ücreti alınacaktır!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankaOtomasyon.Properties.Resources.eft;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(515, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 255);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(865, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtAlanHesap);
            this.Controls.Add(this.txtGonderenHesap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHavale";
            this.Text = "HAVALE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGonderenHesap;
        private System.Windows.Forms.TextBox txtAlanHesap;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}