using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon
{
    public class GelirGider
    {
        public decimal Gelir = 0, Gider = 0;
        public decimal GelenPara (decimal para)
        {
            Gelir += para;

            return Gelir;
        }
        public decimal GidenPara(decimal para)
        {
            Gider += para;

            return Gider;
        }
        public decimal ToplamPara(decimal gelir,decimal gider)
        {
            return gelir - gider;
        }
    }
}
