using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}
