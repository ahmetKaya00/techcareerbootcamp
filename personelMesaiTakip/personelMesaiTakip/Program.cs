using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelMesaiTakip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personel> personelListeli = new List<Personel>();

            while (true)
            {
                Console.WriteLine("1. Personel Girişi");
                Console.WriteLine("2. Personel Çıkışı");
                Console.WriteLine("Programdan Çıkış.");
                Console.Write("Seçim yapınız. (sayısal bir değer)");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1: PersonelGirisi(personelListeli); break;
                    case 2: PersonelCikisi(personelListeli); break;
                    case 3: Environment.Exit(0); break;
                    default: Console.WriteLine("Geçersiz seçenek. Lütfen 1-3 arası bir değer giriniz."); break;

                }
            }
        }

        static void PersonelGirisi(List<Personel> personelListesi)
        {
            Console.Write("Giriş Yapan Personel Adı:");
            string ad = Console.ReadLine();

            if(personelListesi.Exists(p => p.Ad.Equals(ad, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"{ad} şu an da çalışıyor");
                return;
            }


            DateTime girisZamani = DateTime.Now;

            TimeZoneInfo almanyaSaat =TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            DateTime almanyaGirisZamani = TimeZoneInfo.ConvertTime(girisZamani, almanyaSaat);

            Personel personel = new Personel()
            {
                Ad = ad,
                GirisZamani = almanyaGirisZamani
            };

            personelListesi.Add(personel);
            Console.WriteLine($"{ad} saat {almanyaGirisZamani:HH:mm:ss} itibariyle giriş yaptı.");
        }

        static void PersonelCikisi(List<Personel> personelListesi)
        {
            Console.Write("Çıkış Yapan Personel Adı:");
            string ad = Console.ReadLine();
            DateTime girisZamani = DateTime.Now;

            TimeZoneInfo almanyaSaat = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            DateTime almanyaCikisZamani = TimeZoneInfo.ConvertTime(girisZamani, almanyaSaat);

            foreach(var personel in personelListesi)
            {
                if(personel.Ad.Equals(ad, StringComparison.OrdinalIgnoreCase))
                {
                    TimeSpan mesaiSuresi = almanyaCikisZamani - personel.GirisZamani;
                    double mesaiUcreti = mesaiSuresi.TotalHours * 50;

                    Console.WriteLine($"{ad} saat {almanyaCikisZamani: HH:mm:ss} itibariyle çıkış yaptı.");
                    Console.WriteLine($"Mesai Süresi:{mesaiSuresi.TotalHours} saat.");
                    Console.WriteLine($"Mesai Ücreti {mesaiUcreti} $");

                    personelListesi.Remove(personel);
                    return;

                }
            }
            Console.WriteLine("Girmiş olduğunuz personel mesaiye kalmamıştır.");
        }


    }

    class Personel
    {
        public string Ad { get; set; }
        public DateTime GirisZamani { get; set; }
    }
}
