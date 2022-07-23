using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MevsimSecici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1-12 arasında bir sayı giriniz, rastgele değer üretmek için R tuşuna basın");
            //string giris = Console.ReadLine();
            //Random rnd = new Random();
            //int ay = 0;
            //bool rDegil = false;
            //if (giris != "r")
            //{
            //    rDegil = false;
            //}
            //else
            //{
            //    rDegil = true;
            //}
            //while (rDegil == false)
            //{
            //    ay = int.Parse(giris);
            //    switch (ay)
            //    {
            //        case 1:
            //            Console.WriteLine("Kış");
            //            break;
            //        case 2:
            //            Console.WriteLine("Kış");
            //            break;
            //        case 3:
            //            Console.WriteLine("Kış");
            //            break;
            //        case 4:
            //            Console.WriteLine("İlkbahar");
            //            break;
            //        case 5:
            //            Console.WriteLine("İlkbahar");
            //            break;
            //        case 6:
            //            Console.WriteLine("İlkbahar");
            //            break;
            //        case 7:
            //            Console.WriteLine("Yaz");
            //            break;
            //        case 8:
            //            Console.WriteLine("Yaz");
            //            break;
            //        case 9:
            //            Console.WriteLine("yaz");
            //            break;
            //        case 10:
            //            Console.WriteLine("SOnbahar");
            //            break;
            //        case 11:
            //            Console.WriteLine("soonbahar");
            //            break;
            //        case 12:
            //            Console.WriteLine("sonbahar");
            //            break;
            //    }
            //    break;
            //}

            //if (rDegil)
            //{
            //    ay = rnd.Next(13);
            //    switch (ay)
            //    {
            //        case 1:
            //            Console.WriteLine("Kış");
            //            break;
            //        case 2:
            //            Console.WriteLine("Kış");
            //            break;
            //        case 3:
            //            Console.WriteLine("Kış");
            //            break;
            //        case 4:
            //            Console.WriteLine("İlkbahar");
            //            break;
            //        case 5:
            //            Console.WriteLine("İlkbahar");
            //            break;
            //        case 6:
            //            Console.WriteLine("İlkbahar");
            //            break;
            //        case 7:
            //            Console.WriteLine("Yaz");
            //            break;
            //        case 8:
            //            Console.WriteLine("Yaz");
            //            break;
            //        case 9:
            //            Console.WriteLine("yaz");
            //            break;
            //        case 10:
            //            Console.WriteLine("SOnbahar");
            //            break;
            //        case 11:
            //            Console.WriteLine("soonbahar");
            //            break;
            //        case 12:
            //            Console.WriteLine("sonbahar");
            //            break;
            //    }

            //}
            //int month = 0;
            //bool isNumberic;
            //do
            //{
            //    Console.WriteLine("1-12 arasında bir sayı girin veya rastgele üretemek içn R tuşuna basın");
            //    string read = Console.ReadLine();
            //    if (read != "R") isNumberic = int.TryParse(read, out month);
            //    else
            //    {
            //        isNumberic = true;
            //        Random rnd = new Random();
            //        month = rnd.Next(1, 13);
            //    }
            //} while (month <1 || month >12 || isNumberic == false);

            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2: 
            //        Console.WriteLine("Kış"); 
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("yaz");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("sonbahar");
            //        break;
            //}
            #region Toplam Kendi DEneme
            //int adetS = 0;
            //bool numeric;
            //int toplam = 0;
            //int sayac = 1;
            //do
            //{
            //    Console.WriteLine("Lütfen kaç adet sayının ortalamasını girmek istediğinizi yazınız rastgele 5 sayı ortlaması için R basın");
            //    string giris = Console.ReadLine();
            //    if (giris != "R") numeric = int.TryParse(giris, out adetS);
            //    else
            //    {
            //        do
            //        {

            //            Console.WriteLine($"Lütfen {sayac}. sayıyı giriniz");
            //            if (g)

            //                int g = int.Parse(Console.ReadLine());
            //            toplam += g;

            //        } while (sayac < adetS || );

            //        numeric = true;
            //    }

            //} while (numeric == false); 
            #endregion

            string input;
            bool numeric;
            int adet;
            decimal sayi;
            decimal toplam = 0;
            decimal ort;
            int sayac = 1;
            Random rnd = new Random();
            do
            {
                Console.WriteLine("Lütfen kaç adet sayı gireceğinizi yazınız 1-5 arasında rastgele bir sayı adedi için R'ye basınız");
                input = Console.ReadLine();
                if (input!="R")
                {
                    numeric = int.TryParse(input, out adet);
                }
                else
                {
                   
                    numeric = true;
                    adet = rnd.Next(1, 6);
                }
            } while (numeric == false);

            Console.WriteLine($"{adet}");
            
                do
                {
                    Console.WriteLine($"lütfen ortalamasını almak istediğiniz sayılardan {sayac}.cısın giriniz");
                    input = Console.ReadLine();
                    numeric = decimal.TryParse(input, out sayi);

                    if (!numeric)
                    {
                        Console.WriteLine("Lütfen sayısal bir ifade giriniz");
                    }else if (sayi <= 0)
                    {
                        Console.WriteLine("Girilen sayı 0 dan farklı ve pozitif bir sayı olmalıdır");
                    }
                    else
                    {
                        sayac++;
                        toplam += sayi;
                    }
                } while (sayac <= adet);

                ort = toplam / sayac;
                Console.WriteLine($"Girdiğiniz sayıların ortalaması:... {ort}");
            
            Console.WriteLine("Programı kapatmak için bir tuşa basın");
            Console.ReadKey();
        }
    }
}
