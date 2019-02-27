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
    public partial class frmHavale : Form
    {
        // işlem tipi
        // 1 -> para yatırma
        // 2-> para çekme
        // 3 -> havale
        public Musteri m;
        public Banka b;
        public Havale havale;
        public frmHavale()
        {
            InitializeComponent();
        }
        public string Tur;
        public decimal Kesinti;
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtGonderenHesap.Text=="" || txtPara.Text=="" || txtAlanHesap.Text=="" ||txtGonderenHesap.Text=="")
            {
                MessageBox.Show("Bilgiler eksiksiz doldurulmalıdır!");
            }
            else
            {
                Tur = m.TurKontrol(Convert.ToInt32(txtGonderenHesap.Text));
                Kesinti = havale.KesintiIslem(Tur, Convert.ToDecimal(txtPara.Text));
                m.Havale(Convert.ToInt32(txtGonderenHesap.Text), Convert.ToInt32(txtAlanHesap.Text), Convert.ToDecimal(txtPara.Text), Kesinti);

                Log yeniLog = new Log(3, Convert.ToDecimal(txtPara.Text), Convert.ToInt32(txtGonderenHesap.Text), Convert.ToInt32(txtAlanHesap.Text));
                b.LogEkle(yeniLog);
            }
            
            
        }

        private void txtGonderenHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAlanHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGonderenHesap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
