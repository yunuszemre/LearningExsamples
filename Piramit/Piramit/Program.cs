using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y;
            int z = 10;
            for (x = 1; x <= z; x++)
            {
                for (y = 1; y <= z - x; y++)
                {
                    Console.Write(" ");
                }
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                for (y = x - 1; y >= 1; y--)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
