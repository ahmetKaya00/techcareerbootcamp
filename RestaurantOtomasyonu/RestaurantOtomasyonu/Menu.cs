using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonu
{
    internal class Menu
    {
        public delegate void SiparisEventHandler(Siparis siparis);

        public event SiparisEventHandler SiparisAlindi;

        public void MenuGoster()
        {
            Console.WriteLine("Menü");
            Console.WriteLine("1. Pizza ---> 20 TL");
            Console.WriteLine("2. Burger ---> 30 TL");
            Console.WriteLine("3. Lahmacun ---> 15 TL");
            Console.WriteLine("4. Hesap Öde");
        }

        public void SiparisAl(int secim, Siparis siparis)
        {
            switch (secim)
            {
                case 1: siparis.UrunEkle(new Urun("Pizza", 20)); break;
                case 2: siparis.UrunEkle(new Urun("Burger", 30)); break;
                case 3: siparis.UrunEkle(new Urun("Lahmacun", 15)); break;
                case 4: if (SiparisAlindi != null)
                    {
                        SiparisAlindi(siparis);
                    }
                        break;
                default: Console.WriteLine("Geçersiz!"); break;
            }
        }


    }
}
