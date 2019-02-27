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
    public partial class frmLog : Form
    {
        public Banka b;
        public frmLog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text=="")
            {
                MessageBox.Show("Bilgiler eksiksiz doldurulmalıdır!");
            }
            else
            {
                int hesapno = Convert.ToInt32(txtHesapNo.Text);
                DateTime from = From.Value.Date;
                DateTime to = To.Value.Date;
                dataGridView1.DataSource = b.LogGetir(hesapno, from, to);
            }
           
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
