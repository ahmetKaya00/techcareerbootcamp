using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>(5);
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            Console.WriteLine("Çıkarılan Elemanlar");
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());

            Stack<string> stringStack = new Stack<string>(3);
            stringStack.Push("Hello");
            stringStack.Push("World");

            Console.WriteLine("Çıkarılan Elemanlar");
            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Pop());

            Console.ReadLine();
        }
    }
}
