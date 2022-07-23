using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ****************************Recursive-Method*******************************************
             * Kendi içerisinde kendini çağıran methotlardır
             * 
             */
            //Baslangic(10);
            Console.WriteLine(Faktöriyel(1));

            Console.WriteLine(Fibonacci(5));

            // Console.WriteLine(Yaz(-5));
            // Console.WriteLine(Toplam(10, 20));
            Console.ReadKey();
        }
        private static void Baslangic(int sınır)
        {
            Console.WriteLine("Merhaba");
            int sayac = 0;
            if (sayac < sınır)
            {
                sayac++;
                Baslangic(sınır);
            }

        }
        private static double Faktöriyel(double sayi)
        {
            //Faktöriyel(sayi);

            if (sayi == 0 || sayi == 1)
            {
                return 1;
            }
            else
            {
                return sayi * Faktöriyel(sayi - 1);
            }

        }
        //1 1 2 3 5 8...
        private static int Fibonacci(int terimSayisi)
        {
            if (terimSayisi == 0)
            {
                return 0;
            }
            else if (terimSayisi == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(terimSayisi - 2) + Fibonacci(terimSayisi - 1);
            }
        }
        //private static int Yaz(int sayi)
        //{

        //    if (sayi >= 0)
        //    {

        //    }
        //    else
        //    {
        //        return sayi + Yaz(sayi+1);
        //    }
        //}
        //girilen iki sayı arasında 5 e tam bölünenlerin toplamı
        //private static int Toplam(int sayi1, int sayi2)
        //{
        //    int altSinir, ustSinir;
        //    if (sayi1>sayi2)
        //    {
        //        altSinir = sayi2;
        //        ustSinir = sayi1;
        //        return altSinir+ Toplam(altSinir+=5, ustSinir);
        //    }
        //    else
        //    {
        //        altSinir = sayi1;
        //        ustSinir = sayi2;
        //        return altSinir;
        //    }
        //    return altSinir % 5 + Toplam(altSinir, ustSinir);
        //}

    }
}
