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
    public partial class frmHesapSil : Form
    {
        public Musteri m;
        public frmHesapSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text=="")
            {
                MessageBox.Show("Bilgiler eksiksiz doldurulmalıdır!");
            }
            else
            {
                m.HesapSil(Convert.ToInt16(txtHesapNo.Text));
                this.Hide();
            }
            
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
