using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elemanSay = 0;
            int ekok = 0;
            int sayi = 0;
            int indis = -1;

            Console.WriteLine($"Lütfen kaç adet sayının ekok'unu bulacağınızı girin");
            elemanSay = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[elemanSay];
            for (int i = 0; i < elemanSay; i++)
            {
                Console.WriteLine($"Lütfen ekok'unu bulmak istediğiniz sayılardan {i+1}.cisini giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }




            while (expression)
            {
                
            }
            Console.WriteLine($"Girdiğiniz sayıların EKOK'u : {ekok}");
            Console.ReadLine();


        }
    }
}
