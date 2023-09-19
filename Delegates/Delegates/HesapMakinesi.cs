using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void HesapMakinesiDelegate(int x, int y);
    internal class HesapMakinesi
    {
        public static void Topla(int x, int y)
        {
            Console.WriteLine($"Toplam: {x + y}");
        }
        public static void Cikar(int x, int y)
        {
            Console.WriteLine($"Toplam: {x - y}");
        }
    }
}
