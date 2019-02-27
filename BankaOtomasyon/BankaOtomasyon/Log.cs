using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon
{
    public class Log
    {
        public int islemTipi { get; set; }

        public int Kimden { get; set; }

        public int Kime { get; set; }

        public DateTime Tarih { get; set; }

        public decimal Miktar { get; set; }
        public Log()
        {
            this.Tarih = DateTime.Now;
        }
        public Log(int islemTipi, decimal miktar, int kimden, int kime=-1)
        {
            this.Tarih = DateTime.Now;
            this.islemTipi = islemTipi;
            this.Kimden = kimden;
            this.Kime = kime;
            this.Miktar = miktar;
        }
    }
}
