using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktoriyelini hesaplamak istediğiniz sayıyı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            long farktoriyel = FaktoriyelHesaplama(sayi);
            Console.WriteLine($"{sayi}!={farktoriyel}");

            Console.ReadLine();
        }

        static long FaktoriyelHesaplama(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negatif sayıların faktoriyeli alınmaz");
            else if (n == 0 || n == 1)
                return 1;
            else
            {
                long faktoriyel = 1;
                for (int i = 2; i<=n; i++)
                {
                    faktoriyel *= i;
                }
                return faktoriyel;
            }     
        }
    }
}
