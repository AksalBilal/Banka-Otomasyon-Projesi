using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon
{
     public class Banka
    {
        List<Musteri> musteriler = new List<Musteri>();
        List<Log> logs = new List<Log>();
        public int Kontrol = 1;
        public int Kontrol2 = 0;
        public void MusteriEkle(Musteri m)
        {
            musteriler.Add(m);
        }
        public List<Musteri> MusteriListe()
        {
            return musteriler;
        }

        public void MusteriNoKontrol(int no)
        {
            foreach (Musteri m in musteriler)
            {

                if (m.MusteriNo==no)
                {
                    System.Windows.Forms.MessageBox.Show("Kullanılan Müşteri Numarası!");
                    Kontrol = 0;
                }
                else
                {
                    Kontrol = 1;
                }
            }
        }
        public string tur;
        public void HesapKontrol(int musterino,int hesapno)
        {
            foreach (Musteri m in musteriler)
            {
                if (m.MusteriNo == musterino)
                {
                    Kontrol2 = 1;
                    tur = m.Tur;
                    break;
                }
                else
                {
                    Kontrol2 = 0;
                }
            }
        }
        public void LogEkle(Log l)
        {
            this.logs.Add(l);
        }
        public List<Log> LogGetir(int hesapNo, DateTime from, DateTime to)
        {
            List<Log> list = new List<Log>();
            list = logs.Where(x => x.Kimden == hesapNo && (x.Tarih >= from && x.Tarih <= to)).ToList();
            
            return list;
        }

     }
}
