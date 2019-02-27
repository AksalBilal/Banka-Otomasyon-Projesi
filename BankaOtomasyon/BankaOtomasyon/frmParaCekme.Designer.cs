namespace BankaOtomasyon
{
    partial class frmParaCekme
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
            this.btnParaCek = new System.Windows.Forms.Button();
            this.TxtPara = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnParaCek.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnParaCek.Location = new System.Drawing.Point(120, 200);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(162, 82);
            this.btnParaCek.TabIndex = 11;
            this.btnParaCek.Text = "Para Çekme";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // TxtPara
            // 
            this.TxtPara.Location = new System.Drawing.Point(204, 130);
            this.TxtPara.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPara.Name = "TxtPara";
            this.TxtPara.Size = new System.Drawing.Size(123, 22);
            this.TxtPara.TabIndex = 10;
            this.TxtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesapNo_KeyPress);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(204, 64);
            this.txtHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(123, 22);
            this.txtHesapNo.TabIndex = 9;
            this.txtHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesapNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Çekilecek Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hesap Numarası";
            // 
            // frmParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(418, 322);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.TxtPara);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParaCekme";
            this.Text = "PARA ÇEKME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.TextBox TxtPara;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}