using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonu
{
    internal class Siparis
    {
        public List<Urun> Siparisler {  get; private set; }
        public decimal toplamFiyat { get; private set; }

        public Siparis() { 
        
            Siparisler = new List<Urun>();
            toplamFiyat = 0;
        }

        public void UrunEkle(Urun urun)
        {
            Siparisler.Add(urun);
            toplamFiyat += urun.Fiyat;
        }

        public void HesapOde()
        {
            Console.WriteLine("Toplam Hesap: " + toplamFiyat);
        }
    }
}
