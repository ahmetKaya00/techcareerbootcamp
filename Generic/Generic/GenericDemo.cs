using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericDemo
    {
        
        //Generic Method
        public T Add<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        public void Run() {

            int result1 = Add(5, 10);
            double result2 = Add(5.5, 10.2);
            string result3 = Add("Hello", "World");

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

        }

        
    }
}
