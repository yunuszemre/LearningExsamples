using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            Console.ReadKey();
        }
        private static void Yaz(int sayi)
        {
            if (sayi < 100)
            {
                if (sayi % 5 == 0 && sayi % 3 == 0)
                {
                    Console.WriteLine(sayi);
                }

                Yaz(sayi + 1);
            }

        }
        private static void Yaz(double sayi)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);

                }
            }

        }
        private static double Fibonacci(double sayi)
        {

            if (sayi == 1 || sayi == 0)
            {
                return 1;
            }

            return Fibonacci(sayi - 2) + Fibonacci(sayi - 1);
        }
        private static int Carp(int sayi)
        {
            for (int i = sayi; i > 0; i--)
            {
                sayi *= i;
                Console.WriteLine(sayi);
            }
            return sayi;
        }
        //private static int Carp2(int sayi)
        //{
            
        //    if (sayi<=1)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        int res = 1;
        //        res *= sayi;
        //        sayi--;
        //    }
        //    return Carp2(sayi);
        //}


    }

}
