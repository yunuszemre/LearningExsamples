using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 27, 3, 4, 13, 6, 11, 9,2, 0, 5 };
            int[] sortedArr = (int[])bubleSort(numbers);
            for (int i = 0; i < sortedArr.Length; i++)
            {
                Console.WriteLine(sortedArr[i]);
            }
            Console.WriteLine("************************************");
            BubbleSort(numbers);
            Console.ReadLine();
        }
        private static void BubbleSort(int[] arr)
        {
            for (int i = arr.Length-1; i != 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        private static Array bubleSort(int[] arr)
        {
            for (int i= arr.Length-1; i!=0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j+1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
