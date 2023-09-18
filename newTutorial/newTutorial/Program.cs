using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace newTutorial
{

    internal class Program
    {
        private string hesapSahibi;
        private double bakiye;
        
        public Program(string hesapSahibi, double bakiye)
        {
            this.hesapSahibi = hesapSahibi;
            this.bakiye = bakiye;
        }

        public void paraYatir(double miktar)
        {
            if (miktar > 0)
            {
                bakiye += miktar;
                Console.WriteLine($"{hesapSahibi} adlı hesaba {miktar:C2} yatırıldı. Yeni bakiyesi: {bakiye:C2} ");
            }
            else
            {
                Console.WriteLine("Geçersiz Miktar!");
            }
        }
        public void paraCekme(double miktar)
        {
            if(miktar > 0 && miktar <= bakiye)
            {
                bakiye -= miktar;
                Console.WriteLine($"{hesapSahibi} adlı hesaptan {miktar:C2} çekildi. Yeni bakiyesi: {bakiye:C2} ");
            }
            else
            {
                Console.WriteLine("Geçersiz Miktar veya Yetersiz Bakiye");
            }
        }
        public void hesapBilgileriniGoster()
        {
            Console.WriteLine($"Hesap Sahibi: {hesapSahibi}");
            Console.WriteLine($"Bakiye: {bakiye}");
        }
        static void Main(string[] args)
        {

            Program hesap1 = new Program("Ahmet Kaya", 1000);
            hesap1.hesapBilgileriniGoster();

            hesap1.paraYatir(500);
            hesap1.hesapBilgileriniGoster();

            hesap1.paraCekme(200);
            hesap1.hesapBilgileriniGoster();



            Console.Read();


        
    }
        
    }
}
