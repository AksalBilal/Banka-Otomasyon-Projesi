using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon
{
    public class Havale:Musteri
    {
        public override decimal KesintiIslem(string tur,decimal para)
        {
            base.KesintiIslem(tur,para);
            if (tur=="Bireysel")
            {
                para = para - (para * 2) / 100;
            }
            return para;
        }
    }
}
