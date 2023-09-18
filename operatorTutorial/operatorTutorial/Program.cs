using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aritmetik Operatörler

            /*
             +(Toplama)
             -(Çıkarma)
             *(Çarpma)
             /(Bölme)
             %(Mod)
            */
            int sayi1 = 10;
            int sayi2 = 20;
            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int carpim = sayi1 * sayi2;
            int bolum = sayi1 / sayi2;
            int kalan = sayi1 % sayi2;
            Console.WriteLine($"Toplam: {toplam}");
            Console.WriteLine($"Fark: {fark}");
            Console.WriteLine($"Çarpım: {carpim}");
            Console.WriteLine($"Bölüm: {bolum}");
            Console.WriteLine($"Kalan: {kalan}");

            //Atama Operatör
            /*
             = (atama)
            += (Toplama ve Atama)
            -= (Çıkarma ve Atama)
            *= (Çarpma ve Atama)
            /= (Bölme ve Atama)
            */

            int x = 5;

            x += 3;
            x -= 3;
            x *= 3;
            x /= 3;

            Console.WriteLine($"x: {x}");

            //Karşılaştırma Operatörleri

            /*
             ==(Eşitlik)
            != (Eşitsizlik)
             <> (Küçüktür - Büyüktür)
            <= >= (KüçükEşit / Büyük Eşit)
            */

            int sayiA = 10;
            int sayiB = 5;

            bool esitMi = sayiA == sayiB;
            bool esitDegilmi = sayiA != sayiB;
            bool buyukMu = sayiA > sayiB;
            bool kucukMu = sayiA < sayiB;

            Console.WriteLine($"Eşit Mi: {esitMi}");
            Console.WriteLine($"Eşit Değil Mi: {esitDegilmi}");
            Console.WriteLine($"Büyük Mü: {buyukMu}");
            Console.WriteLine($"Küçük Mü: {kucukMu}");

            //Mantıksal Operatörler
            /*
             &&(VE) Kesinlik
             ||(VEYA)Arada
             ! (DEĞİL)
            */

            bool kosul1 = true;
            bool kosul2 = false;

            bool sonuc1 = kosul1 && kosul2;
            bool sonuc2 = kosul1 || kosul2;
            bool sonuc3 = !kosul1;

            Console.WriteLine($"Sonuç 1: {sonuc1}");
            Console.WriteLine($"Sonuç 2: {sonuc2}");
            Console.WriteLine($"Sonuç 3: {sonuc3}");

            //Arttırma ve Azaltma
            /*
             ++(Arttırma)
             --(Azaltma)
            */

            int a = 5;
            a++;
            a--;
            Console.WriteLine($"a: {a}");

            // Koşul operatörü ?

            int yas = 18;

            string sonuc = (yas >= 18) ? "Ehliyet Alabilir" : "Ehliyet Alamaz";
            Console.WriteLine($"Sonuç: {sonuc}");

            //Koşul İfadeleri if - else if - else

            int yasA = 19;

            if(yasA >= 18)
            {
                Console.WriteLine("Ehliyet Alabilir");
            }else if(yasA >= 16)
            {
                Console.WriteLine("Motor Ehliyeti Alabilir");
            }
            else
            {
                Console.WriteLine("Ehliyet Alamaz");
            }

            //Switch - Case (Branching)

         //  Console.Write("En Sevdiğiniz Meyve: ");
         //  string meyve = Console.ReadLine();
         //
         //  switch (meyve.ToLower())
         //  {
         //      case "elma":
         //          Console.WriteLine("Elma Seviliyor");
         //          break;
         //      case "armut":
         //          Console.WriteLine("Armut Seviliyor");
         //          break;
         //      case "muz":
         //          Console.WriteLine("Muz Seviliyor");
         //          break;
         //      default:
         //          Console.WriteLine("Girmiş Olduğun Meyvenin Adını İlk Defa Duydum");
         //          break;
         //  }

            // Döngüler
            /*
             for Döngüsü: 
            */

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Döngü Çalışıyor. İterasyon: " + i);
            }

            //While Döngüsü

            int sayac = 0;

            while(sayac < 5)
            {
                Console.WriteLine("Döngü çalışıyor. Sayaç: " + sayac);
                sayac++;
            }

            //do-while

            int sayac2 = 0;

            do
            {
                Console.WriteLine("Döngü çalışıyor. sayac: " + sayac2);
                sayac2++;
            } while (sayac2 < 5);

            //foreach Döngüsü

            string[] isimler = { "Ahmet", "Ayşegül", "Furkan", "Sercan" };
            foreach(string isim in isimler)
            {
                Console.WriteLine("İsim: " + isim);
            }











            Console.ReadLine();
        }
    }
}
