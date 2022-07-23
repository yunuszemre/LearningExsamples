using System;

namespace Mayın_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] bombs = new int[4, 4]
            {
                { 4, 12, 20, 28 },
                { 4, 12, 20, 28 },
                { 4, 12, 20, 28 },
                { 4, 12, 20, 28 }
            };
            bool alive = true;
            bool isWon = false;
            int left = 4;
            int top = 4;
            int bombXpos = 0;
            int bombXpos2 = 0;
            int bombYpos = 0;
            int bombYpos2 = 0;
            ConsoleKey? key = null;

            Console.WriteLine(bombs[0, 0].ToString());
            Console.WriteLine(bombs[1, 1].ToString());
            Console.WriteLine(bombs[1, 2].ToString());
            Console.WriteLine(bombs[3, 3].ToString());

            #region Bombalar başlangı karesinin ilk sağında ve ilk altında aynı andaysa yeniden konumlandır

            do
            {
                bombXpos = rnd.Next(0, 4);
                bombXpos2 = rnd.Next(0, 4);
                bombYpos = bombs[bombXpos, rnd.Next(0, 4)];
                bombYpos2 = bombs[bombXpos, rnd.Next(0, 4)];
                Console.SetCursorPosition(70, 5);
                Console.WriteLine(bombXpos2);
                switch (bombXpos)
                {
                    case 0:
                        bombXpos = 4;
                        break;
                    case 1:
                        bombXpos = 20;
                        break;
                    case 2:
                        bombXpos = 36;
                        break;
                    case 3:
                        bombXpos = 52;
                        break;
                }
                switch (bombXpos2)
                {
                    case 0:
                        bombXpos2 = 4;
                        break;
                    case 1:
                        bombXpos2 = 20;
                        break;
                    case 2:
                        bombXpos2 = 36;
                        break;
                    case 3:
                        bombXpos2 = 52;
                        break;
                }
            } while (bombXpos == 20 && bombYpos == 4 || bombXpos2 == 20 && bombYpos2 == 4 && bombXpos == 4 && bombYpos == 12 || bombXpos2 == 4 && bombYpos2 == 12 || bombYpos == bombYpos2 && bombXpos == bombXpos2 || bombXpos == 4 && bombYpos == 4 || bombXpos == 52 && bombYpos == 28 || bombXpos2 == 4 && bombYpos2 == 4 || bombXpos2 == 52 && bombYpos2 == 28);
            #endregion


            do
            {
                #region Bomba Konumlarını Ekrana Yazdır
                Console.Clear();
                Console.SetCursorPosition(70, 1);
                Console.Write($"Sol: {left.ToString()} Üst: {top.ToString()}");
                Console.SetCursorPosition(70, 3);
                Console.WriteLine($"1.BombaX: {bombXpos}, 1.BombaY: {bombYpos}");
                Console.SetCursorPosition(70, 5);
                Console.WriteLine($"2.BombaX: {bombXpos2}, 2.BombaY: {bombYpos2}");
                Console.SetCursorPosition(bombXpos, bombYpos);
                Console.WriteLine("BOMBA1");
                Console.SetCursorPosition(bombXpos2, bombYpos2);
                Console.WriteLine("BOMBA2");
                #endregion

                #region SatırÇiz
                //Satır Çiz
                for (int j = 0; j < 40; j++)
                {
                    if (j % 8 == 0)
                    {
                        Console.SetCursorPosition(0, j);
                        for (int k = 0; k < 32; k++)
                        {
                            Console.Write("* ");
                        }

                    }
                }
                #endregion

                #region SütunÇiz
                //Sütun Çiz
                Console.SetCursorPosition(0, 0);
                int yPos = 0;
                for (int i = 0; i < 64; i++)
                {
                    if (i % 16 == 0 || i == 63)
                    {
                        Console.SetCursorPosition(i, 0);
                        for (int j = 0; j < 32; j++)
                        {
                            yPos += 1;
                            Console.SetCursorPosition(i, yPos);
                            Console.Write("*");
                        }
                        if (yPos == 32)
                        {
                            yPos = 0;
                        }
                    }
                }
                #endregion

                #region Hareket
                #region TavşanÇiz
                Console.CursorVisible = false;
                Console.SetCursorPosition(left, top);
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.SetCursorPosition(left + 2, top + 1);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("*");
                    Console.SetCursorPosition(left + 2, top + j);
                } 
                #endregion
                
                key = Console.ReadKey().Key;

                if (key == ConsoleKey.RightArrow && left < 40)
                {
                    left += 16;
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    if (left > 16)
                        left -= 16;
                }
                else if (key == ConsoleKey.UpArrow && top > 8)
                {
                    top -= 8;
                }
                else if (key == ConsoleKey.DownArrow && top < 28)
                {
                    top += 8;
                }
                #endregion

                #region Kazanma-Ölme Kontrol

                if (top == bombYpos && left == bombXpos || top == bombYpos2 && left == bombXpos2)
                {
                    alive = false;
                    break;
                }

                if (top == 28 && left == 52)
                {
                    isWon = true;
                    break;
                }
                #endregion

            } while (key == ConsoleKey.UpArrow || key == ConsoleKey.RightArrow || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow);

            if (isWon)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 24, Console.WindowHeight / 2);
                Console.Write("*******TEBRİKLER ÇIKIŞA ULAŞTIN*******");
            }
            else if (!alive)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2);
                Console.WriteLine("XXXXXX-ÖLDÜN-XXXXXXX");
            }



            Console.ReadLine();
        }
    }
}