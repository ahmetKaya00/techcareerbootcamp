using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullaniciGirisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogruKullaniciAdi = "kullanici";
            string dogruSife = "sifre";
            int hataliGirisSayisi = 0;
            DateTime? sonHataliGirisTarihi = null;

            while(hataliGirisSayisi < 2)
            {
                Console.Write("Kullanıcı Adı:");
                string kullaniciAdi = Console.ReadLine();

                Console.Write("Şifre:");
                string sifre = Console.ReadLine();

                if(kullaniciAdi == dogruKullaniciAdi && sifre == dogruSife)
                {
                    Console.WriteLine($"{dogruKullaniciAdi} Hoşgeldin.");
                    Console.WriteLine("Giriş Tarihi ve Saati:" + DateTime.Now);

                    if(sonHataliGirisTarihi.HasValue)
                    {
                        Console.WriteLine("Son Hatalı Giriş Tarihi ve Saati: " + sonHataliGirisTarihi);
                    }
                    break; // Doğru giriş yapılınca döngüden çıktım

                }
                else
                {
                    hataliGirisSayisi++;
                    Console.WriteLine("Hatalı Giriş! Kalan Hakkınız: " + (2 - hataliGirisSayisi)); 
                    sonHataliGirisTarihi = DateTime.Now;
                }

            }
            if(hataliGirisSayisi >= 2)
            {
                Console.WriteLine("Hesabınız Bloke Edildi");
            }


            Console.ReadLine();
        }
    }
}
