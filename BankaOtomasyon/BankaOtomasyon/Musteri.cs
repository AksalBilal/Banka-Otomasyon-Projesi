using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon
{
    public class Musteri:Kisi
    {
        public int MusteriNo { get; set; }
        public string Tur { get; set; }

        public List<Hesap> Hesaplar = new List<Hesap>();

        public void HesapOlustur(Hesap h)
        {
            Hesaplar.Add(h);
        }
        public List<Hesap> HesapListe()
        {
            return Hesaplar;
        }

        public void HesapSil(int hesapno)
        {
            bool bulunduMu = false;
            int index = -1;
            foreach (Hesap h in Hesaplar)
            {
                index++;
                if (h.HesapNo == hesapno && h.Bakiye==0)
                {
                    bulunduMu = true;
                    System.Windows.Forms.MessageBox.Show("Hesap Silme işlemi Tamamlandı.");
                    break;
                }

            }
            if (bulunduMu)
                Hesaplar.RemoveAt(index);
            else
            {
                System.Windows.Forms.MessageBox.Show("Hesap Silinemedi.");
            }
        }

        public void ParaYatir(int hesapno, decimal para)
        {
            decimal p;
            k = 0;
            foreach (Hesap h in Hesaplar)
            {
                if (h.HesapNo == hesapno)
                {
                    k++;
                    if (h.Tur=="Ticari" && h.EkHesapBakiyesi!=1000)
                    {
                        p = 1000 - h.EkHesapBakiyesi;
                        h.EkHesapBakiyesi += p;
                        h.Bakiye += para - p;
                    }
                    if (h.Tur == "Bireysel" && h.EkHesapBakiyesi != 500)
                    {
                        p = 500 - h.EkHesapBakiyesi;
                        h.EkHesapBakiyesi += p;
                        h.Bakiye += para - p;
                    }
                    System.Windows.Forms.MessageBox.Show("Para Yatırma İşleminiz Başarılı");
                    break;
                }
            }
            if (k == 0)
            {
                System.Windows.Forms.MessageBox.Show("Hatalı Hesap Numarası");
            }
        }
        public void ParaCek(int hesapno, decimal para)
        {
            k = 0;
            foreach (Hesap h in Hesaplar)
            {
                k++;
                if (h.HesapNo == hesapno)
                {
                    if (para > 750)
                    {
                        System.Windows.Forms.MessageBox.Show("Günlük Para Çekme Limiti 750TL'dir.");
                    }
                    else if (h.Bakiye - para + h.EkHesapBakiyesi < 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Yetersiz Bakiye");
                    }
                    else if (para > h.Bakiye)
                    {
                        h.EkHesapBakiyesi -= (para - h.Bakiye);
                        h.Bakiye = 0;
                        System.Windows.Forms.MessageBox.Show("Para Çekme İşleminiz Tamamlanmıştır");
                    }
                    else
                    {
                        h.Bakiye -= para;
                        System.Windows.Forms.MessageBox.Show("Para Çekme İşleminiz Tamamlanmıştır");
                    }
                    break;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Kayıtlı Olmayan Müşteri Numarası");
                }
            }
            if (k==0)
            {
                System.Windows.Forms.MessageBox.Show("Hatalı Hesap Numarası");
            }
        }
        public string hesapturu;
        public string TurKontrol(int hesapno1)
        {
            foreach (Hesap h in Hesaplar)
            {
                if (h.HesapNo == hesapno1)
                {
                    hesapturu = h.Tur;
                }
            }
            return hesapturu;
        }
        public virtual decimal KesintiIslem(string tur, decimal para)
        {
            this.hesapturu = tur;
            return 0;
        }



        public int HavaleKontrol = 1,k=0;
        public void Havale(int gonderen, int alan, decimal para, decimal kesintipara)
        {
            k = 0;
            foreach (Hesap h in Hesaplar)
            {
                if (h.HesapNo == gonderen)
                {
                    k++;
                }
                if (h.HesapNo == alan)
                {
                    k++;
                }
            }


            foreach (Hesap h in Hesaplar)
            {
                if (h.HesapNo == gonderen && k==2)
                {
                    if (h.Bakiye - para < 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Yetersiz Bakiye");
                        HavaleKontrol = 0;
                        break;
                    }
                    else
                    {
                        h.Bakiye = h.Bakiye - para;
                        HavaleKontrol = 1;
                    }

                }

                if (h.HesapNo == alan && HavaleKontrol==1 && k==2)
                {
                    h.Bakiye = h.Bakiye + kesintipara;
                    System.Windows.Forms.MessageBox.Show("Havele İşlemi Gerçekleşmiştir.");
                }
            }
            if (k!=2)
            {
                System.Windows.Forms.MessageBox.Show("Hesap Numaralarını Kontrol Ediniz.");
            }
        }

    }
}
