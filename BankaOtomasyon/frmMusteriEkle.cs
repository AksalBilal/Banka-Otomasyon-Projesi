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
    public partial class frmMusteriEkle : Form
    {
        public Banka b;

        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMusteriNo.Text=="" || txtAd.Text=="" || txtSoyad.Text=="" || cmbTur.Text=="")
            {
                MessageBox.Show("Bilgiler Eksiksiz Olmalıdır!");
            }

            else
            {
                Musteri m = new Musteri();
                m.Ad = txtAd.Text;
                m.Soyad = txtSoyad.Text;
                m.Tur = cmbTur.Text;
                m.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                b.MusteriNoKontrol(Convert.ToInt32(txtMusteriNo.Text));
                if (b.Kontrol == 1)
                {
                    b.MusteriEkle(m);
                    MessageBox.Show("Müşteri Numarası Eklendi");
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = b.MusteriListe();
            }
            
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
    }
}
