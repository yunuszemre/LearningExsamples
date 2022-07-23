using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region kullaıcıdan alınan sayıya kadar olan tüm sayıları toplamı+

            #region Algoritma
            /*
                     * 1.başla
                     * sayi değ. olş.
                     * siinr değ. olş
                     * kullanıcıdan sinir değişkenini al
                     * sayi = sayi+i ile sayinin değerine kadar topla
                     * ekrana sayi değ. yazdir
                     * bitir
            */
            #endregion

            #region Kod

            //Console.Write($"Bir sayi giriniz...");
            //ulong sinir = Convert.ToUInt64(Console.ReadLine());
            //ulong sayi = 0;

            //for (int i = 0; i <= sinir; i++)
            //{
            //    sayi = sayi + i;
            //}
            //Console.WriteLine($"{sinir}'e kadar olan sayiların toplamı {sayi}");

            #endregion

            #endregion

            #region 1-40a arası çift sayiların toplamı

            #region Algoritma
            /*
             * 1.başla
             * 2. 1-40 arası çalışan döngü aç
             * 3. toplam değişk. olş.
             * 4. i %2== 0 sa toplam = toplam+i işlemini yap
             * 5. toplamı ekrana yazdır
             * 6.bitir
             */
            #endregion

            #region kod
            //decimal toplam = 0;
            //for (int i = 1; i <= 40; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam = toplam + i;
            //    }
            //}
            //Console.WriteLine(toplam); 
            #endregion

            #endregion

            #region kull. gird. sayıya kadar piramit
            /*
             * 1.Başla
             * 2.sayi değ. olş.
             * 3.kullanıcıdan sayi değ. al
             * 4.1 dens sayi değ.. kadar çalışan döngü aç
             * 5.
             *
             */
            //int sayi = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j.ToString());
            //    }
            //    Console.WriteLine();
            //}


            #endregion
            #region ÇarpımTablosu

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (j == 10)
                    {
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine($"i * j = {i * j}");
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
