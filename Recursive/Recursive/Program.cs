using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 2, 7, 0, 11, 27, 2, 3, 3, 5, 4, 1, -1, -3000 };
            int[] sorted = new int[numbers.Length];
            char[] s = { 'H', 'e', 'l', 'l', 'o' };
            char[] reversed = new char[s.Length];
            reversed = ReverseString(s);
            foreach (var VARIABLE in reversed)
            {
                Console.WriteLine(VARIABLE);
            }
            //sorted = BubbleSort(numbers);
            //sorted = SelectionSort(numbers);
            //sorted = InsertionSort(numbers);
            //sorted = Sort(numbers);
            // Console.WriteLine(Topla(7));
            //foreach (int item in sorted)
            //{
            //    Console.WriteLine(item);
            //}
            //int tekToplam = 0;
            //int ciftToplam = 0;
            //Console.WriteLine(FaktöriyelRecursive(10));
            //Console.WriteLine(Toplam(100));
            //Console.WriteLine(Fark1(100));
            //Console.WriteLine(Palindrome("hava"));
            //Console.WriteLine(Fibonacci(100,1,1));
            //Console.WriteLine(Fibonacci(100));
            //Console.WriteLine(FarkRecursive(101));
            //Console.WriteLine(Fark1(101));
            //Console.WriteLine(Palindrome("s12121s"));
            //Console.WriteLine(IsPalindrome("ececece"));
            Console.ReadLine();
        }

        private static double FaktöriyelHesapla(int sayi)
        {
            if (sayi <= 1)
                return 1;
            double res = 1;
            for (int i = sayi; i > 1; i--)
            {
                res = res * i;
            }
            return res;
        }

        private static double FaktöriyelRecursive(int sayi)
        {
            if (sayi <= 1)
                return 1;
            return sayi * FaktöriyelHesapla(sayi - 1);
        }

        private static int Toplam(int sayi)
        {
            if (sayi == 0)
                return 0;

            return sayi + Toplam(sayi - 1);
        }

        private static void Fark2(int sayi, int tekToplam, int ciftToplam)
        {

            if (sayi == 100)

                if (sayi % 2 == 0 && sayi < 100)
                {
                    ciftToplam += sayi;

                }
                else if (sayi % 2 != 0 && sayi < 100)
                {
                    tekToplam += sayi;
                }
            sayi++;
            //Fark(sayi, tekToplam, ciftToplam);
        }

        private static int Fark1(int sayi)
        {
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            return tekToplam - ciftToplam;
        }


        private static decimal Fibonacci(decimal n, decimal onceki = 1, decimal suAndki = 1)
        {
            if (n <= 2)
                return suAndki;
            else
            {

                return Fibonacci(n - 1, suAndki, onceki + suAndki);
            }

        }

        private static double Fibonacci(double n)
        {
            if (n <= 2)
                return n;
            else
            {
                Console.WriteLine(Fibonacci(n - 2) + Fibonacci(n - 1));
                return Fibonacci(n - 2) + Fibonacci(n - 1);
            }
        }

        private static double FarkRecursive(int limit, int tekTop = 0, int ciftTop = 0)
        {
            if (limit <= 0)
                return tekTop - ciftTop;

            else if (limit % 2 == 0)
                ciftTop += limit;

            else
                tekTop += limit;

            return FarkRecursive(limit - 1, tekTop, ciftTop);
        }

        private static string Palindrome(string s, string deger = "", int index = 0)
        {
            bool isPalindrome = false;
            if (s == deger)
            {
                isPalindrome = true;
                Console.WriteLine(isPalindrome);
                return deger;
            }
            else if (index == s.Length)
            {
                isPalindrome = false;
                Console.WriteLine(isPalindrome);
                return deger;
            }
            return Palindrome(s, deger += s[s.Length - index - 1], index + 1);

        }
        private static bool IsPalindrome(string s, int index = 0)
        {
            if (s[index] != s[s.Length - 1 - index])
            {
                return false;
            }

            if (index >= s.Length / 2)
            {
                return true;
            }
            return IsPalindrome(s, index + 1);
        }

        private static int[] BubbleSort(int[] arr)
        {
            for (int i = arr.Length - 1; i != 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
            return arr;
        }

        private static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = minIndex + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }

                    if (arr[i] > arr[minIndex] && arr[i] != arr[minIndex])
                    {
                        (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
                    }
                }
            }
            return arr;
        }

        private static int[] SelSortWhile(int[] arr)
        {
            int index = 0;

            while (index < arr.Length - 1)
            {

                int minIndex = index;
                index++;
                while (minIndex + 1 < arr.Length)
                {
                    if (arr[index] < arr[minIndex])
                    {
                        minIndex = index;
                    }

                    if (arr[index] > arr[minIndex] && (arr[index] != arr[minIndex + 1]))
                    {
                        (arr[index], arr[minIndex]) = (arr[minIndex], arr[index]);
                    }
                    minIndex++;
                }
            }
            return arr;
        }

        private static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                //for (int j = i; j !=0; j--)
                //{
                //    if (arr[j] < arr[j-1])
                //    {
                //        (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                //    }
                //}

                int index = i;
                while (index > 0)
                {
                    if (arr[index] < arr[index - 1])
                    {
                        (arr[index], arr[index - 1]) = (arr[index - 1], arr[index]);
                    }

                    index--;
                }
            }

            return arr;
        }

        private static int[] Merge(int[] arr1, int[] arr2)
        {
            int firstPointer = 0;
            int secondPointer = 0;
            int[] mergedArray = new int[0];

            while (firstPointer < arr1.Length && secondPointer < arr2.Length)
            {
                if (arr1[firstPointer] < arr2[secondPointer])
                {
                    Array.Resize(ref mergedArray, mergedArray.Length + 1);
                    mergedArray[mergedArray.Length - 1] = arr1[firstPointer];
                    firstPointer++;
                }
                else
                {
                    Array.Resize(ref mergedArray, mergedArray.Length + 1);
                    mergedArray[mergedArray.Length - 1] = arr2[secondPointer];
                    secondPointer++;
                }

                while (firstPointer < arr1.Length)
                {
                    Array.Resize(ref mergedArray, mergedArray.Length + 1);
                    mergedArray[mergedArray.Length - 1] = arr1[firstPointer];
                    firstPointer++;
                }

                while (secondPointer < arr2.Length)
                {
                    Array.Resize(ref mergedArray, mergedArray.Length + 1);
                    mergedArray[mergedArray.Length - 1] = arr2[secondPointer];
                    secondPointer++;
                }
            }
            return mergedArray;
        }

        private static int[] Sort(int[] arr)
        {
            if (arr.Length == 1)
                return arr;

            int midPoint = arr.Length / 2;
            int[] leftPart = new int[midPoint];
            int[] rightPart = new int[midPoint];
            Array.ConstrainedCopy(arr, 0, leftPart, 0, midPoint);
            Array.ConstrainedCopy(arr, midPoint - 1, rightPart, 0, midPoint);

            return Merge(Sort(leftPart), Sort(rightPart));
        }

        private static int Topla(int sayi)
        {
            if (sayi == 0)
            {
                return 0;
            }
            else
            {
                return sayi + Topla(sayi - 1);
            }
        }

        private static char[] ReverseString(char[] arr, int i = 0)
        {
            if (i == arr.Length)
            {
                return arr;
            }
            else
            {
                (arr[i], arr[arr.Length-i-1]) = (arr[arr.Length-i-1], arr[i]);
            }
            return ReverseString(arr, i + 1);
        }
    }
}
