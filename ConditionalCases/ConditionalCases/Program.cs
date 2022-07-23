using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * If-Else-Switch
             * If: if(şart<lar>)
             * {
             *  İşlemler
             * }else if(şart<lar>)
             * {
             * İşlemler
             * }else
             * {
             * işlemler
             * }
             * ********************************************************************************
             * Ternary if
             * Değişken = Koşul ? Doğru kısım : Yanlış kısım
             **********************************************************************************
             * Switch (takip edilen değişken)
             *{       case (değer):
             *       işlemler;
             *       break;
             *}
             * if kontorlünde sırasıyla tüm şartlar kontrol ediliyorken Switch yapısında değer hangi case e uyuyorsa direkt o case çalıştırılır;
             * Bu nedenle Switch yapısı if yapısından daha performanslı çalışır.
             */
            #region icecek siparisi

            //Console.WriteLine("Almak istediğiniz içeceğin kodunu giriniz");
            //string kod = Console.ReadLine();
            //Switch (kod)
            //{
            //    case "m":
            //    Console.WriteLine("Meyve suyu siparişiniz alındı");
            //    break;
            //    default:

            //    break;

            //}



            #endregion

            #region kucukBuyukSayi

            Console.WriteLine($"1. sayıyı giriniz");

            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"2. sayıyı giriniz");

            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi2)

                Console.WriteLine($"Sayı bir {sayi1} > {sayi2} den");
            
            else if (sayi2 > sayi1)

                Console.WriteLine($"Sayı iki {sayi2} > {sayi1} den");
            
            else

                 Console.WriteLine($"Sayılar birbirine eşit {sayi1} = {sayi2}");
            
           

            Console.ReadLine();

            #endregion


        }
    }
}
