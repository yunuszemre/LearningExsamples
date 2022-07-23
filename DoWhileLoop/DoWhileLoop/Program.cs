using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //int sayi = 0;
            //int toplam = 0;
            //int sayac = 0;
            //char key = 'y';

            //do
            //{
            //    sayac++;
            //    Console.WriteLine($"Lütfen toplamak istediğiniz sayılardan {sayac}.cısını girin");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    Console.Write("Başka sayı girmek istiyor musunuz Yes(y), No(n)...");
            //    key = Console.ReadKey().KeyChar;
            //    Console.WriteLine();
            //} while (key != 'n');

            //Console.WriteLine($"{sayac} adet sayı girildi, girdiğiniz sayiların toplamı => {toplam}"); 
            #endregion
            /*
             * break;
             * continue;
             * return;
             */

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    return;
                }
            }




            Console.ReadKey();

        }
    }
}
