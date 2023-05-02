using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeler
{
    class Sifre
    {
        // Gerekli degiskenler tanımlandı
        public static int buyukHarfPuan;
        public static int kucukHarfPuan;
        public static int rakamPuan;
        public static int sembolPuan;
        public static int genelPuan;

        public static int buyukHarfSayisi;
        public static int kucukHarfSayisi;
        public static int rakamSayisi;
        public static int sembolSayisi;

        // Buyuk harf sayısını ve puanını bulan metot olusturuldu
        public static void BuyukHarfBul(string sifre)
        {
            buyukHarfPuan = 0;
            buyukHarfSayisi = 0;
            string icindekiHarf = " ";
            char[] buyukHarfler = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'Y', 'Z' };
            foreach (var sifreHarf in sifre)
            {
                foreach (var buyukHarf in buyukHarfler)
                {
                    if (sifreHarf == buyukHarf)
                    {
                        icindekiHarf += " " + sifreHarf + " ";
                        buyukHarfSayisi++;
                        buyukHarfPuan += 10;

                        if (buyukHarfSayisi >= 3)
                            buyukHarfPuan = 20;
                    }
                }
            }
            string ok = "\t --->";
            if (buyukHarfSayisi == 0)
                ok = " ";

            Console.WriteLine("Büyük Harf Sayısı: {0} {1} {2}", buyukHarfSayisi, ok, icindekiHarf);

            Console.WriteLine("Büyük Harf Puan: " + buyukHarfPuan);
        }

        // Kucuk harf sayısını ve puanını bulan metot olusturuldu
        public static void KucukHarfBul(string sifre)
        {
            kucukHarfPuan = 0;
            kucukHarfSayisi = 0;
            string icindekiHarf = " ";
            char[] kucukHarfler = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'y', 'z' };
            foreach (var sifreHarf in sifre)
            {
                foreach (var kucukHarf in kucukHarfler)
                {
                    if (sifreHarf == kucukHarf)
                    {
                        icindekiHarf += " " + sifreHarf + " ";
                        kucukHarfSayisi++;
                        kucukHarfPuan += 10;

                        if (kucukHarfSayisi >= 3)
                            kucukHarfPuan = 20;
                    }
                }
            }
            string ok = "\t --->";
            if (kucukHarfSayisi == 0)
                ok = " ";

            Console.WriteLine("Küçük Harf Sayısı: {0} {1} {2}", kucukHarfSayisi, ok, icindekiHarf);

            Console.WriteLine("Küçük Harf Puan: " + kucukHarfPuan);
        }

        // Rakam sayısını ve puanını bulan metot olusturuldu
        public static void RakamBul(string sifre)
        {
            rakamPuan = 0;
            rakamSayisi = 0;
            string icindekiRakam = " ";
            char[] rakamlar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (var sifreRakam in sifre)
            {
                foreach (var rakam in rakamlar)
                {
                    if (sifreRakam == rakam)
                    {
                        icindekiRakam += " " + sifreRakam + " ";
                        rakamSayisi++;
                        rakamPuan += 10;

                        if (rakamSayisi >= 3)
                            rakamPuan = 20;
                    }
                }
            }
            string ok = "\t --->";
            if (rakamSayisi == 0)
                ok = " ";

            Console.WriteLine("Rakam Sayısı: {0} {1} {2}", rakamSayisi, ok, icindekiRakam);

            Console.WriteLine("Rakam Puan: " + rakamPuan);
        }

        // Sembol sayısını ve puanını bulan metot olusturuldu
        public static void SembolBul(string sifre)
        {
            sembolPuan = 0;
            sembolSayisi = 0;
            string icindekiSembol = " ";
            char[] semboller = { '.', ',', '/', '*', '-', '+', '?', '|', '_', '-', '(', ')', '{', '}', '[', ']', '=', ';', '^', '#', '!', '$', '%', '&', '"', '<', '>', ':' };
            foreach (var sifreSembol in sifre)
            {
                foreach (var sembol in semboller)
                {
                    if (sifreSembol == sembol)
                    {
                        icindekiSembol += " " + sifreSembol + " ";
                        sembolSayisi++;
                        sembolPuan += 10;
                    }
                }
            }
            string ok = "\t --->";
            if (sembolSayisi == 0)
                ok = " ";

            Console.WriteLine("Sembol Sayısı: {0} {1} {2}", sembolSayisi, ok, icindekiSembol);

            Console.WriteLine("Sembol Puan: " + sembolPuan);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ** Şifre 9 ve üzeri karakter ise kabul edilebilir
            ** Şifre 9 karakter ise 10 puan ilave edilir.
            ** 9 karakter ve üzeri ise büyük harf, küçük harf, rakam ve sembol sayısının hiçbiri sıfır olmamalı,
            ** Her hangi birinin sayısı sıfır ise şifre kabul edilemez, değilse kabul edilebilir. 
            */

            bool kontrol = true;

            // Sifre yanlis girildiği takdirde tekrar girilmesi için do while döngüsü kullanıldı
            do
            {
                // Sifre kullanıcıdan istendi
                Console.Write("Şifrenizi giriniz: ");
                string sifre = Console.ReadLine();

                // Sifrenin karakter sayisi foreach döngüsü ile yapıldı
                int karakterSayisi = 0;
                foreach (var item in sifre)
                {
                    karakterSayisi++;
                }
                Console.WriteLine("Karakter Sayısı: {0}", karakterSayisi);
                Console.WriteLine();

                // Sifre icinde bosluk olup olmadıgı foreach döngüsü ile kontrol edildi
                char bosluk = ' ';
                int boslukSayisi = 0;
                foreach (var boslukVarMi in sifre)
                {
                    if (boslukVarMi == bosluk)
                        boslukSayisi++;
                }

                // Metotlar kullanıldı
                Sifre.BuyukHarfBul(sifre);
                Sifre.KucukHarfBul(sifre);
                Sifre.RakamBul(sifre);
                Sifre.SembolBul(sifre);
                Console.WriteLine();


                // Genel puan hesaplandı
                Sifre.genelPuan = Sifre.buyukHarfPuan + Sifre.kucukHarfPuan + Sifre.rakamPuan + Sifre.sembolPuan;
                if (karakterSayisi == 9)
                {
                    Sifre.genelPuan += 10;
                }
                Console.WriteLine("Genel Puan: {0}", Sifre.genelPuan);

                // Sifrenin kurallarini kontrol etmesi için if - else yapısı kullanıldı, gerekli kosullar yazıldı
                if (boslukSayisi == 0 && karakterSayisi >= 9 && Sifre.buyukHarfSayisi != 0 && Sifre.kucukHarfSayisi != 0 && Sifre.rakamSayisi != 0 && Sifre.sembolSayisi != 0)
                {
                    kontrol = true;
                    if (Sifre.genelPuan >= 70 && Sifre.genelPuan < 90)
                        Console.WriteLine("Genel Puan 70 ile 90 arasında , Şifre Kabul Edildi ");
                    if (Sifre.genelPuan >= 90)
                        Console.WriteLine("Genel Puan 90 dan büyük - Şifre Kabul Edildi - GÜÇLÜ ŞİFRE");
                }
                else
                {
                    kontrol = false;
                    if (Sifre.genelPuan < 70)
                        Console.WriteLine("Genel Puan 70'den Küçük Şifre Kabul Edilemez...");

                    if (boslukSayisi != 0)
                        Console.WriteLine("Şifre Boşluk İçeriyor.");

                    if (karakterSayisi < 9)
                        Console.WriteLine("Şifre 9 Karakterden Az.");

                    if (karakterSayisi >= 9)
                    {
                        if (Sifre.buyukHarfSayisi == 0)
                            Console.WriteLine("Şifre Büyük Harf İçermiyor.");

                        if (Sifre.kucukHarfSayisi == 0)
                            Console.WriteLine("Şifre Küçük Harf İçermiyor.");

                        if (Sifre.rakamSayisi == 0)
                            Console.WriteLine("Şifre Rakam İçermiyor.");

                        if (Sifre.sembolSayisi == 0)
                            Console.WriteLine("Şifre Sembol İçermiyor.");
                    }

                    Console.WriteLine("Tekrar deneyiniz...");
                    Console.WriteLine();
                }

            } while (kontrol != true);

            Console.Read();
        }
    }
}
