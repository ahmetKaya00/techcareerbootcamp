using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int result1 = calculator.Add(5, 10);
            Console.WriteLine("Toplam 1:" + result1);

            int result2 = calculator.Add(5, 10,15);
            Console.WriteLine("Toplam 2:" + result2);

            double result3 = calculator.Add(5.3, 10.5);
            Console.WriteLine("Toplam 3: " + result3);

            Console.ReadLine();
        }
    }
}
