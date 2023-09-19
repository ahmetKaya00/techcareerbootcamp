using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonu
{
    internal class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public Urun (string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
    }
}
