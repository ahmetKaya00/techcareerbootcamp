using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Siparis siparis = new Siparis();

            menu.SiparisAlindi += (sip) => { sip.HesapOde(); };

            while (true)
            {
                menu.MenuGoster();
                Console.Write("Seçiminizi Yapın (1-4)");
                int secim = Convert.ToInt32(Console.ReadLine());
                menu.SiparisAl(secim, siparis);
            }


        }
    }
}
