using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lojistikConsoleOtomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOOTCAM LTD. ŞTİ.");

            Console.Write("Kullanıcı Adını Giriniz:");
            string kulllaniciAdi = Console.ReadLine();

            Console.Write("Şifre Giriniz:");
            string sifre = Console.ReadLine();

            if (GirisYap(kulllaniciAdi, sifre))
            {
                Console.WriteLine("Giriş Başarılı \n");

                List<Kamyon> kamyonlar = new List<Kamyon>
                {
                    new Kamyon("Ahmet", "Üzüm", "Adana",2,DateTime.Now.AddHours(1)),
                    new Kamyon("Ali", "Karpuz", "Diyarbakır",3,DateTime.Now.AddHours(2)),
                    new Kamyon("Ayşe", "Simit", "İzmir",4,DateTime.Now.AddHours(3))
                };

                Console.WriteLine("Kamyonlar:");
                foreach (var kamyon in kamyonlar)
                {
                    Console.WriteLine(kamyon.Ad);
                }
                Console.Write("\nHangi Kamyonu seçmek istiyorsun. ? (Kamyon Adını Giriniz)");
                string secilenKamyonAdi = Console.ReadLine();

                Kamyon secilenKamyon = null;
                foreach (var kamyon in kamyonlar)
                {
                    if (kamyon.Ad == secilenKamyonAdi)
                    {
                        secilenKamyon = kamyon; break;
                    }
                }

                if (secilenKamyon != null)
                {
                    Console.WriteLine($"\n{secilenKamyon.Ad} kamyonu seçildi");
                    Console.WriteLine($"Taşınan ürün {secilenKamyon.Urun}");
                    Console.WriteLine($"Gideceği Şehir: {secilenKamyon.Sehir}");
                    DateTime varisSaati = secilenKamyon.HareketSaati.AddHours(secilenKamyon.VarisSuresi);
                    Console.WriteLine($"Tahmini Varış Süresi: {varisSaati}");

                    TimeSpan beklemeSuresi = secilenKamyon.HareketSaati - DateTime.Now;
                     Console.WriteLine($"\nKamyonun hareket etmesine: {beklemeSuresi.ToString().Substring(0,5)}");
                    Thread.Sleep(beklemeSuresi);

                    Console.WriteLine("\nKamyon hareket ediyor");
                }
                else
                {
                    Console.WriteLine("Geçersiz Kamyon Adı");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz Kullanıcı Adı Şifre");
            }
            Console.ReadLine();
        }
        static bool GirisYap(string kullaniciAdi, string sifre)
        {
            return kullaniciAdi == "admin" && sifre == "12345";
        }
    }
    class Kamyon
    {
        public string Ad { get; set; }
        public string Urun { get; set; }
        public string Sehir { get; set; }
        public int VarisSuresi { get; set; }
        public DateTime HareketSaati { get; set; }

        public Kamyon(string ad, string urun, string sehir, int varisSuresi, DateTime hareketsaati)
        {
            Ad = ad;
            Urun = urun;
            Sehir = sehir;
            VarisSuresi = varisSuresi;
            HareketSaati = hareketsaati;
        }
    }
}

