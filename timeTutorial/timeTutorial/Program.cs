using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace timeTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  //DateTime  //TimeSpan
            //
            //  DateTime now = DateTime.Now; // Mevcut tarihi ve saati alır
            //  DateTime Tomorrow = new DateTime(2023, 9, 12);
            //  TimeSpan fark = Tomorrow - now;
            //
            //
            //  //DateTimeOffset
            //
            //  DateTimeOffset dtOffset = DateTimeOffset.Now;
            //
            //  //TimeZone
            //
            //  TimeZoneInfo istanbulZamani = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standart Time"); // İstanbul saat //dilimi            
            //  DateTime istanbulZamaniNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, istanbulZamani);
            //
            //  //System.Diagnostics.Stopwatch
            //
            //  Stopwatch stopup = new Stopwatch();
            //  stopup.Start(); // Zamanı Başlattım
            //
            //  //İşlemleri Gerçkleştirdim
            //
            //  stopup.Stop(); // Zamanı Durdurmuş Oldum
            //  TimeSpan gecenSure = stopup.Elapsed; // Geçen süreyi al

          //  Console.WriteLine("Zaman İşlemleri Projesi. \n");
          //
          //  //Mevcut Tarihi Alalım
          //  DateTime baslangicZamani = DateTime.Now;
          //  Console.WriteLine("Başlangıç Zamanı: " + baslangicZamani);
          //
          //  //Belirli bir süre bekleme
          //  int beklemeSure = 5;
          //  Console.WriteLine($"Program {beklemeSure} saniye bekliyor...");
          //  Thread.Sleep(beklemeSure * 1000);
          //
          //  //Geçen Süreyi Hesapla
          //  DateTime bitisZamani = DateTime.Now;
          //  TimeSpan gecenSure = bitisZamani - baslangicZamani;
          //  Console.WriteLine("Bitiş Zamanı: " + bitisZamani);
          //  Console.WriteLine("Geçen Süre: " + gecenSure.TotalSeconds + "saniye");
          //
          //  Console.ReadLine();





            // break - contiune

          //  for(int i = 0; i < 10; i++)
          //  {
          //
          //      if (i == 5)
          //      {
          //          Console.WriteLine("Döngü Sonlanıyor");
          //          break;
          //      }
          //      Console.WriteLine(i);
          //  }

         //     for(int i = 0; i < 10; i++)
         //   {
         //       if(i%2 == 0)
         //       {
         //           Console.WriteLine($"{i} çift sayıdır.");
         //           continue;
         //       }
         //       Console.WriteLine($"{i} tek sayıdır.");
         //   }
         //   
         //
         //   Console.ReadLine();
        }
    }
}
