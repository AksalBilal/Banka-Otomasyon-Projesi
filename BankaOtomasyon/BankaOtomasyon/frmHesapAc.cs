using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyon
{
    public partial class frmHesapAc : Form
    {
        public Musteri m;
        public Banka b;
        public frmHesapAc()
        {
            InitializeComponent();
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if(txtMusteriNo.Text=="")
            {
                MessageBox.Show("Bilgiler eksiksiz doldurulmalıdır!");
            }
            else
            {
                Hesap h = new Hesap();
                Random sayi = new Random();
                int no = sayi.Next(100, 1000);
                b.HesapKontrol(Convert.ToInt16(txtMusteriNo.Text), no);
                if (b.Kontrol2 == 1)
                {
                    h.MusteriNo = Convert.ToInt16(txtMusteriNo.Text);
                    h.HesapNo = no;
                    h.Bakiye = 0;
                    h.Tur = b.tur;
                    MessageBox.Show("Hesap Açma Başarılı");
                    if (h.Tur == "Ticari")
                    {
                        h.EkHesapBakiyesi = 1000;
                    }
                    else
                    {
                        h.EkHesapBakiyesi = 500;
                    }
                    m.HesapOlustur(h);


                }
                b.Kontrol2 = 0;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = m.HesapListe();
            }
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = m.HesapListe();
        }

        private void frmHesapAc_Load(object sender, EventArgs e)
        {
            
        }

        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
