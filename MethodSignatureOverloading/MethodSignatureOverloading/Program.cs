using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MethodSignatureOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double doubleToplam = Sum(12.2, 5);
        burası:
            int intToplam = Sum(10, 12, 20, 30, 40, 50, 0, 60, 700);
            int toplam = Sum(12, 20);
            Console.WriteLine(intToplam);
            Console.ReadKey();

        }

        public static int Sum(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;

            return result;
        }

        public static double Sum(double sayi1, double sayi2)
        {
            double result = sayi1 + sayi2;
            return result;
        }

        public static short Sum(short sayi1, short sayi2)
        {
            short result = (short)(sayi1 + sayi2);
            return result;
        }

        public static ulong Sum(ulong sayi1, ulong sayi2)
        {
            ulong result = (ulong)(sayi1 + sayi2);
            return result;
        }

        public static long Sum(long sayi1, long sayi2)
        {
            long result = sayi2 + sayi1;
            return result;
        }
        public static byte Sum(byte sayi1, byte sayi2)
        {
            byte result = (byte)(sayi1 + sayi2);
            return result;
        }
        public static sbyte Sum(sbyte sayi1, sbyte sayi2)
        {
            sbyte result = (sbyte)(sayi1 + sayi2);
            return result;
        }
        public static decimal Sum(decimal sayi1, decimal sayi2)
        {
            decimal result = (decimal)(sayi1 + sayi2);
            return result;
        }
        public static float Sum(float sayi1, float sayi2)
        {
            float result = (float)(sayi1 + sayi2);
            return result;
        }

        public static int Sum(params int[] sayilar)
        {
            int result = 0;

            foreach (int item in sayilar)
            {
                result += item;
            }
            return result;
        }

    }
}
