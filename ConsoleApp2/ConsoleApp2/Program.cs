using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xindex1 = 2;
            int xindex2 = 2;
            int bomba1x = 0;
            int bomba1y = 0;
            int bomba2x = 0;
            int bomba2y = 0;
            Random rnd = new Random();
            int[,] bombalar = new int[4, 4]
            {
        {2,6,10,14},
        {2,6,10,14},
        {2,6,10,14},
        {2,6,10,14},

            };
            do
            {
                bomba1x = rnd.Next(0, 4);
                bomba1y = bombalar[bomba1x, rnd.Next(0, 4)];
                bomba2x = rnd.Next(0, 4);
                bomba2y = bombalar[bomba2x, rnd.Next(0, 4)];
                switch (bomba1x)
                {
                    case 0:
                        bomba1x = 2;
                        break;
                    case 1:
                        bomba1x = 8;
                        break;
                    case 2:
                        bomba1x = 14;
                        break;
                    case 3:
                        bomba1x = 20;
                        break;
                }
                switch (bomba2x)
                {
                    case 0:
                        bomba2x = 2;
                        break;
                    case 1:
                        bomba2x = 8;
                        break;
                    case 2:
                        bomba2x = 14;
                        break;
                    case 3:
                        bomba2x = 20;
                        break;
                }
            } while (bomba1x == 2 && bomba1y == 2 || bomba2x == 2 && bomba2y == 2 || bomba1x == 20 && bomba1y == 14 || bomba2x == 20 && bomba2y == 14 || bomba1x == 8 && bomba1y == 2 && bomba2x == 2 && bomba2y == 6 || bomba1x == 2 && bomba1y == 6 && bomba2x == 8 && bomba2y == 2);

            KareleriOlustur(xindex1, xindex2);
            while (true)
            {
                
                Console.SetCursorPosition(bomba1x, bomba1y);
                Console.Write("BOM");
                Console.SetCursorPosition(bomba2x, bomba2y);
                Console.Write("BOM");

                char basilan = Console.ReadKey().KeyChar;
                
                if (basilan == 'd' || basilan == 'D' || basilan == 'w' || basilan == 'W' || basilan == 'a' || basilan == 'A' || basilan == 's' || basilan == 'S')
                {
                    Console.WriteLine("devame et");

                    if (xindex1 < 19)
                    {
                        if (basilan == 'd' || basilan == 'D')
                        {
                            xindex1 = xindex1 + 6;
                            KareleriOlustur(xindex1, xindex2);
                        }
                    }
                    if (xindex1 > 0)
                    {
                        if (basilan == 'a' || basilan == 'A')
                        {
                            int temp = xindex1 - 6;
                            if (temp > 0)
                            {
                                xindex1 = temp;
                                KareleriOlustur(xindex1, xindex2);
                            }
                        }
                    }
                    if (xindex2 > 0)
                    {
                        if (basilan == 'W' || basilan == 'w')
                        {
                            int temp = xindex2 - 4;
                            if (temp > 0)
                            {
                                xindex2 = temp;
                                KareleriOlustur(xindex1, xindex2);
                            }
                        }
                    }
                    if (xindex2 < 11)
                    {
                        if (basilan == 's' || basilan == 'S')
                        {
                            xindex2 = xindex2 + 4;
                            KareleriOlustur(xindex1, xindex2);
                        }
                    }
                    if (xindex1 == bomba1x && xindex2 == bomba1y || xindex1 == bomba2x && xindex2 == bomba2y)
                    {
                        Console.Clear();
                        Console.WriteLine("bomba patladı!!!!!!");
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(70, 3);
                    Console.WriteLine("lütfen yön tuşlarını kullanınız.");
                    Console.ReadKey();
                    Console.Clear();
                    
                }
                if (xindex1 == 20 && xindex2 == 14)
                {
                    Console.Clear();
                    Console.WriteLine("kazandınız:)))))))))))");
                    break;
                }
                Console.CursorVisible = false;
                
            }

            Console.ReadKey();
        }

        static void KareleriOlustur(int a, int b)
        {

            for (int i = 0; i < 19; i = i + 6)
            {
                KareCiz(i, 0);
                KareCiz(i, 4);
                KareCiz(i, 8);
                KareCiz(i, 12);
                
            }
            SekliCiz(a, b);
        }
        static void KareCiz(int index1, int index2)
        {
            Console.SetCursorPosition(index1, index2);
            Console.Write(Char.ConvertFromUtf32(9484));
            Console.Write(new string((char)9472, 4));
            Console.Write(Char.ConvertFromUtf32(9488));
            Console.SetCursorPosition(index1, index2 + 1);
            Console.Write("{0}    {0}", Char.ConvertFromUtf32(9474));
            Console.SetCursorPosition(index1, index2 + 2);
            Console.Write("{0}    {0}", Char.ConvertFromUtf32(9474));
            Console.SetCursorPosition(index1, index2 + 3);
            Console.Write(Char.ConvertFromUtf32(9492));
            Console.Write(new string((char)9472, 4));
            Console.Write(Char.ConvertFromUtf32(9496));
        }
        static void SekliCiz(int abc1, int abc2)
        {
            Console.SetCursorPosition(abc1, abc2);
            Console.Write("X");
        }

        }
    }

