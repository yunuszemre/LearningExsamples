using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 232, 4, 3, 5, 634, 7548, 345, 11, 75, 3, 2 };
            int[] sorted = new int[numbers.Length];

            sorted = InsertionSort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(sorted[i]);
            }
            
            Console.ReadLine();
        }
        private static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (temp < arr[j] && j>0)
                {
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }
            return arr;
        }
    }
}
