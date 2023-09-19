using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        public event EventHandler Baslatildi;

        public void Calistir()
        {
            Console.WriteLine("Program Çalıştı");

            //Eventi tetikle
            OnBaslatildi();

        }
        protected virtual void OnBaslatildi()
        {
            Baslatildi?.Invoke(this, EventArgs.Empty);
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Baslatildi += (sender, e) =>
            {
                Console.WriteLine("Başlatıldı eventi tetiklendi");
            };
            program.Calistir();

            Console.ReadLine();


        }
    }
}
