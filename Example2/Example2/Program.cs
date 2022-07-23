using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Lütfen toplamak istediğiniz sayılardan ilkini giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen toplamak istediğiniz sayılardan ikincisini giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sayıların toplamı: {a + b}");
            Console.ReadLine();
            //List<int> sayilar = new List<int> {  };
            //for (int i = 0; i < 5; i++)
            //{
            //    sayilar.Add = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.ReadLine();

        }
    }
}
