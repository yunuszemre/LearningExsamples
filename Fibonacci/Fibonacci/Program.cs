using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool fibSayi = false;
            int res = 0;
            int i = 0;
            while (i<=100)
            {
                if (i>=2)
                {
                    if (((i - 2) + (i - 1)) == i)
                    {
                        res = i;
                    }
                }
                
            }
            Console.WriteLine($"{res} Fibonacci Sayısıdır");
            Console.ReadLine();

        }
    }
}
