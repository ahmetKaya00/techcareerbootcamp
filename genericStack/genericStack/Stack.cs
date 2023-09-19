using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericStack
{
    internal class Stack<T>
    {
        private T[] items;
        private int top;

        public Stack(int size)
        {
            items = new T[size];
            top = -1;
        }

        public void Push(T item)
        {
            if(top == items.Length - 1)
            {
                Console.WriteLine("Yığın doldu!");
                return;
            }
            items[++top] = item;
        }
        public T Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Yığın Boş");
                return default(T);
            }
            return items[top--];
        }
    }
}
