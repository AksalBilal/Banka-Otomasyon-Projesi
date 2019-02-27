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
    public partial class frmGelirGider : Form
    {
        public GelirGider gg;
        public frmGelirGider()
        {
            InitializeComponent();
        }

        private void frmGelirGider_Load(object sender, EventArgs e)
        {
            decimal Gelir = gg.GelenPara(0);
            decimal Gider = gg.GidenPara(0);
            decimal Toplam = gg.ToplamPara(Gelir,Gider);
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = Gelir;
            dataGridView1.Rows[0].Cells[1].Value = Gider;
            dataGridView1.Rows[0].Cells[2].Value = Toplam;
        }
    }
}
