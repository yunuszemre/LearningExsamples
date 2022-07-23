using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdamManavSebzeHali
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("************BilgeAdamBoostMarket/SebzeHali***************");
            Console.SetCursorPosition(0, 1);
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("*******************Keyifli Alışverişler******************");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.SetCursorPosition(1, 1);
            Console.WriteLine(" 1. Pırasa");
            Console.WriteLine(" 2. Ispanak");
            Console.SetCursorPosition(1, 2);
            Console.SetCursorPosition(1, 3);
            Console.WriteLine(" 3. Havuç");
            Console.SetCursorPosition(1, 4);
            Console.WriteLine(" 4. Turp");
            Console.SetCursorPosition(1, 5);
            Console.WriteLine(" 5. Brokoli");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine(" 6. Sarımsak");
            Console.SetCursorPosition(1, 7);
            Console.WriteLine(" 7. Pancar");
            Console.SetCursorPosition(1, 8);
            Console.WriteLine(" 8. Domates");
            Console.SetCursorPosition(1, 9);
            Console.WriteLine(" 9. Salatalık");
            Console.SetCursorPosition(1, 10);
            Console.WriteLine(" 10. Marul");
            yanlisSayi:
            Console.SetCursorPosition(0,12);
            Console.WriteLine("*******************Keyifli Alışverişler******************");
            Console.Write("Lütfen almak istediğiniz ürünün numarasını giriniz: ");
            string vegetable = Console.ReadLine();

            switch (vegetable)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Pırasadır");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Ispanaktır");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Havuçtur");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Turptur");
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Brokolidir");
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Sarımsaktır");
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Pancardır");
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Domatestir");
                    break;
                case "9":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Salatalıktır");
                    break;
                case "10":
                    Console.Clear();
                    Console.WriteLine($"Siparişiniz Maruldur");
                    break;
                default:
                    Console.WriteLine("Lütfen ekranda görülen ürün numaralarından birini giriniz..");
                    goto yanlisSayi;
                    break;
            }



            Console.ReadLine();
        }
    }
}
