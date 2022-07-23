using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek-1
            ////Ekrandan n tane sayı alınıp sayıların daha önceden dizide olup olmadığı kont yapılarak sayıların toplamı
            ///*
            // * Kaç sayı girecek sor
            // */
            //bool sayisalMi = false;
            //int adet;
            //int sayi;
            //int toplam = 0;
            //int deger = 0;

            //do
            //{
            //    Console.WriteLine("Lütfen kaç adet sayı toplayacağınızı giriniz");
            //    string input = Console.ReadLine();
            //    sayisalMi = int.TryParse(input, out adet);
            //} while (!sayisalMi);

            //int[] sayilar = new int[adet];

            //do
            //{
            //    Console.WriteLine($"Lütfen sayılardan {deger + 1}.cisini giriniz ");
            //    string input = Console.ReadLine();
            //    sayisalMi = int.TryParse(input, out sayi);
            //    if (sayilar.Contains(sayi))
            //    {
            //        Console.WriteLine("Girilen sayılar aynı olamaz");
            //    }
            //    else
            //    {
            //        sayilar[deger] = sayi;
            //        toplam += sayilar[deger];
            //        deger++;
            //    }

            //} while (sayisalMi && deger < adet);

            //Console.WriteLine($"Sayıların toplamı {toplam}"); 
            #endregion

            #region Örnek-2
            //sayı al, tekrar girmek istiyor mu sor hayırsa toplamı göster
            /*
             * girdi değişkenini oluştur
             * kullanıcıdan sayıyı al
             * sayıyı diziye ekle
             * kullanıcıya tekrar sayı girmek istiyor mu sor evetse 2. adıma git hayırsa sıonraki adıma geç
             * sayılalrın toplamını ekran yazdır
             *
             */
            #region Kod
            //string girdi;
            //int sayi;
            //int index = 0;
            //int[] toplam = new int[1];
            //bool devamMı = true;
            //int sonuc = 0;
            //do
            //{
            //    Console.Write("Lütfen toplanacak sayılları girin..:");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam[index] = sayi;
            //    Console.Write("Daha sayı girmek istiyor musunuz? E (Evet) H(Hayır)..:");
            //    girdi = Console.ReadLine();

            //    if (girdi == "e" || girdi == "E")
            //    {
            //        devamMı = true;
            //        index++;
            //        Array.Resize(ref toplam, toplam.Length + 1);
            //    }
            //    else
            //    {
            //        for (int i = 0; i < toplam.Length; i++)
            //        {
            //            sonuc += toplam[i];
            //        }
            //        break;
            //    }
            //} while (devamMı);

            //Console.WriteLine($"{index + 1} tane sayının toplamı {sonuc}"); 
            #endregion
            #endregion

            #region Örnek-3

            #endregion

            

            Console.ReadLine();


        }
    }
}
