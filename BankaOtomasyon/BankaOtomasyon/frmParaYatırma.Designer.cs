namespace BankaOtomasyon
{
    partial class frmParaYatırma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.TxtPara = new System.Windows.Forms.TextBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yatırılacak Tutar";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(204, 56);
            this.txtHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(132, 22);
            this.txtHesapNo.TabIndex = 4;
            this.txtHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPara_KeyPress);
            // 
            // TxtPara
            // 
            this.TxtPara.Location = new System.Drawing.Point(204, 124);
            this.TxtPara.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPara.Name = "TxtPara";
            this.TxtPara.Size = new System.Drawing.Size(132, 22);
            this.TxtPara.TabIndex = 5;
            this.TxtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPara_KeyPress);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnParaYatir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnParaYatir.Location = new System.Drawing.Point(114, 189);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(166, 86);
            this.btnParaYatir.TabIndex = 6;
            this.btnParaYatir.Text = "Para Yatırma";
            this.btnParaYatir.UseVisualStyleBackColor = false;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // frmParaYatırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(414, 322);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.TxtPara);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParaYatırma";
            this.Text = "PARA YATIRMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox TxtPara;
        private System.Windows.Forms.Button btnParaYatir;
    }
}