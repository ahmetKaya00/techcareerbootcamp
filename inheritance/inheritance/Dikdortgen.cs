using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

        class Dikdortgen : Sekil
        {
            public double Uzunluk { get; set; }
            public double Genislik { get; set; }

            // Üst sınıftan miras alınan metodu üzerine yazma (override)
            public override double AlanHesapla()
            {
                return Uzunluk * Genislik;
            }
        }
}
