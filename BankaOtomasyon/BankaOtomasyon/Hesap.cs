using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon
{
    public class Hesap
    {
        public int MusteriNo { get; set; }
        public int HesapNo { get; set; }
        public decimal Bakiye { get; set; }
        public string Tur { get; set; }
        public decimal EkHesapBakiyesi { get; set; }
        public DateTime AcilisTarihi { get; set; }
        public Hesap()
        {
            this.AcilisTarihi = DateTime.Now;
        }
    }
}
