using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HesapMakinesiDelegate toplamlamaDelegate = HesapMakinesi.Topla;
            HesapMakinesiDelegate cikarmaDelegate = HesapMakinesi.Cikar;


            toplamlamaDelegate(5, 8);
            cikarmaDelegate(5, 3);

            HesapMakinesiDelegate hesaplamaDelegate = toplamlamaDelegate + cikarmaDelegate;
            hesaplamaDelegate(5, 2);

            Console.ReadKey();


        }
    }
}
