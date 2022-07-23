using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerEzample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 1, 2, 3 };
            //int[] sayılar2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //int[] sayilar3 = new int[100];

            //object[] objeler = { 1234, 'b', 'c', 'd', 'e', 'f', "Emre", sayilar3, DateTime.Now };

            //Kullanıcıdan alınan 5 sayının toplamı

            
            //decimal[] sayilar = new decimal[3];
            //decimal ort = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. sayıyı girin");
            //    sayilar[i] = Convert.ToDecimal(Console.ReadLine());
            //    ort += sayilar[i];

            //}

            //ort = ort / sayilar.Length;


            //Console.WriteLine(ort);
            Console.WriteLine("***********************Çok Boyutlu Diziler********************");

            int[,] degerler = new int[2, 3]

            {
                { 3, 2, 1 },
                { 1, 2, 3 }

            };

            #region Üç Öğrenci Vize Final
            //3 öğrencinin vize ve final notlarını alarak, %70, %30 şeklinde ort ekrana yazdır
            /*
             *3,2 lik iki boyutlu dizi oluştur
             *
             */
            //double[,] notlar = new Double[10, 2];
            //for (int i = 0; i < notlar.GetUpperBound(0); i++)
            //{
            //    Console.WriteLine($"{i + 1}, Öğrencinin vize notu");
            //    notlar[i, 0] = (Convert.ToDouble(Console.ReadLine()) * 0.3);

            //    for (int j = 0; j < notlar.GetUpperBound(1); j++)
            //    {
            //        Console.WriteLine($"{i + 1}, Öğrencinin final notu");
            //        notlar[i, 1] = (Convert.ToDouble(Console.ReadLine()) * 0.7);
            //        double ort = notlar[i, 0] + notlar[i, 1];
            //        Console.WriteLine($"{i + 1}. Öğrencinin ortalaması..: {ort} ");
            //    } 
                
            //}
            #endregion





            Console.ReadKey();

        }
    }
}
