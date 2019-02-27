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
    public partial class Form1 : Form
    {
        frmHesapAc frm = new frmHesapAc();
        public Banka b;
        public Musteri m;
        public Hesap h;
        public Havale havale;
        public GelirGider gg;
        public Form1()
        {
            InitializeComponent();
            b = new Banka();
            m = new Musteri();
            h = new Hesap();
            havale = new Havale();
            gg = new GelirGider();
        }
         
        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frm = new frmMusteriEkle();
            frm.MdiParent = this;
            frm.b = this.b;
            frm.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hesapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapAc frm = new frmHesapAc();
            frm.MdiParent = this;
            frm.m = this.m;
            frm.b = this.b;
            frm.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaYatırma frm = new frmParaYatırma();
            frm.MdiParent = this;
            frm.m = this.m;
            frm.b = this.b;
            frm.gg = this.gg;
            frm.Show();
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaCekme frm = new frmParaCekme();
            frm.MdiParent = this;
            frm.m = this.m;
            frm.b = this.b;
            frm.gg = this.gg;
            frm.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavale frm = new frmHavale();
            frm.MdiParent = this;
            frm.m = this.m;
            frm.b = this.b;
            frm.havale = this.havale;
            frm.Show();
        }

        private void bankaGelirGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelirGider frm = new frmGelirGider();
            frm.MdiParent = this;
            frm.gg= this.gg;
            frm.Show();
        }

        private void hesapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapSil frm2 = new frmHesapSil();
            frm2.MdiParent = this;
            frm2.m = this.m;
            frm2.Show();
            frm.Hide();
        }

        private void hesapDökümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLog frm = new frmLog();
            frm.MdiParent = this;
            frm.b = this.b;
            frm.Show();
        }
    }
}
