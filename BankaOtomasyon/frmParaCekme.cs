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
    public partial class frmParaCekme : Form
    {
        public Musteri m;
        public GelirGider gg;
        public Banka b;
        public frmParaCekme()
        {
            InitializeComponent();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            if(txtHesapNo.Text=="" || TxtPara.Text=="")
            {
                MessageBox.Show("Bilgiler eksiksiz doldurulmalıdır!");
            }
            else
            {
                m.ParaCek(Convert.ToInt32(txtHesapNo.Text), Convert.ToDecimal(TxtPara.Text));


                gg.GidenPara(Convert.ToDecimal(TxtPara.Text));
                Log yeniLog = new Log(2, Convert.ToDecimal(TxtPara.Text), Convert.ToInt32(txtHesapNo.Text));
                b.LogEkle(yeniLog);
            }
            
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
