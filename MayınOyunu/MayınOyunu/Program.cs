using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayınOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 16; i++)
            {
                Console.Write("* ");
            }
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("*");
            }
            Console.SetCursorPosition(0, 16);
            for (int i = 0; i < 16; i++)
            {
                Console.Write("* ");
            }
            Console.SetCursorPosition(32, 0);
            for (int i = 0; i <= 16; i++)
            {
                Console.SetCursorPosition(32, i);
                Console.WriteLine("*");
            }
            Console.SetCursorPosition(0, 4);
            for (int i = 0; i < 16; i++)
            {
                
                Console.Write("* ");
            }
            Console.SetCursorPosition(0, 8);
            for (int i = 0; i < 16; i++)
            {

                Console.Write("* ");
            }
            Console.SetCursorPosition(0, 12);
            for (int i = 0; i < 16; i++)
            {

                Console.Write("* ");
            }
            Console.SetCursorPosition(8, 0);
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(8, i);
                Console.WriteLine("*");
            }
            Console.SetCursorPosition(16, 0);
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(16, i);
                Console.WriteLine("*");
            }
            Console.SetCursorPosition(24, 0);
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(24, i);
                Console.WriteLine("*");
            }

            Random rnd = new Random();
            int xPos = rnd.Next(30);
            int yPos = rnd.Next(16);
            if (xPos == 0 || xPos == 8 || xPos == 24 || xPos == 32)
            {
                xPos = rnd.Next(32);
            }

            if (yPos == 0 || yPos == 4 || yPos == 8 || yPos == 12 || yPos == 16)
            {
                yPos = rnd.Next(16);
            }

            Console.SetCursorPosition(xPos, yPos);
            Console.Write("X");
            
            //char key = (char)Console.ReadKey().Key;




            Console.ReadLine();
        }
    }
}
