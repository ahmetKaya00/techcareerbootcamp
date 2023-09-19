using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dikdörtgen nesnesi oluştur
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.Uzunluk = 5;
            dikdortgen.Genislik = 3;

            // Alanı hesapla ve yazdır
            double alan = dikdortgen.AlanHesapla();
            Console.WriteLine($"Dikdörtgen Alanı: {alan}");

            // Bekleme
            Console.ReadLine();
        }
    }

}
