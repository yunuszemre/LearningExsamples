using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvdeGetirtarifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            List<string> sepet = new List<string>();
            products.Add("1L Kutu Süt", 17.99m);
            products.Add("6'lı Yumurta", 28.99m);
            products.Add("5L Aycicek Yagi", 110.50m);
            products.Add("6'lı Margarin", 45.45m);
            products.Add("3Kg Yogurt", 25.99m);
            products.Add("1L Zeytin Yagi", 125.25m);
            products.Add("1Kg Kıyma", 115m);
            products.Add("30'lu Yumurta", 45.99m);
            products.Add("Dis Macunu", 27.99m);
            products.Add("Dis Fırçası", 17.99m);
            decimal toplam = 0;
            int r = 0;
            devam:
            for (int i = 0; i <= 20; i++)
            {
                if (i == 0)
                {
                    Console.SetCursorPosition(Console.WindowWidth/2, 0);
                    Console.Write(
                        "*******************************");
                    Console.SetCursorPosition(Console.WindowWidth/2-27, 0);
                    Console.Write(
                        "*******************************");

                }
                else if (i < 20 && i != 0)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2-27 ,i);
                    Console.WriteLine(
                        "*                                                        *");
                                                   
                }
                
                else
                {
                    //Console.SetCursorPosition(Console.WindowWidth / 2 , 20);
                    Console.SetCursorPosition(Console.WindowWidth / 2, 20);
                    Console.Write(
                        "*******************************");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 27, 20);
                    Console.Write(
                        "*******************************");
                }
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth/2-26, i+2);
                switch (i)
                {
                    case 0:
                        Console.Write($"{i+1} 1L Kutu Süt {products["1L Kutu Süt"]}Tl");
                        break;
                    case 1:
                        Console.WriteLine($"{i + 1} 6'lı Yumurta {products["6'lı Yumurta"]}Tl");
                        break;
                    case 2:
                        Console.WriteLine($"{i + 1} 5L Aycicek Yagi {products["5L Aycicek Yagi"]}Tl");
                        break;
                    case 3:
                        Console.WriteLine($"{i + 1} 6'lı Margarin {products["6'lı Margarin"]}Tl");
                        break;
                    case 4:
                        Console.WriteLine($"{i + 1} 3Kg Yogurt {products["3Kg Yogurt"]}Tl");
                        break;
                    case 5:
                        Console.WriteLine($"{i + 1} 1L Zeytin Yagi {products["1L Zeytin Yagi"]}Tl");
                        break;
                    case 6:
                        Console.WriteLine($"{i + 1} 30'lu Yumurta {products["30'lu Yumurta"]} Tl");
                        break;
                }
            }
            
            Console.SetCursorPosition(Console.WindowWidth/2-26,10);
            Console.Write("Sepete eklemek istediğiniz ürünün numarasını giriniz...");
            
            string s = Console.ReadLine();
            
            Console.SetCursorPosition(Console.WindowWidth / 2 - 26, 11);
            switch (s)
                {
                    
                    case "1": 
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 26, 11);
                        Console.Write($"1L Kutu Süt {products["1L Kutu Süt"]} Sepete Eklendi ");
                        sepet.Add("1L Kutu Süt");
                        toplam = toplam + products["1L Kutu Süt"];
                        Console.WriteLine($"Sepet Tutarı {toplam}TL");
                        break;
                    case "2":
                        Console.Write($"6'lı Yumurta {products["6'lı Yumurta"]} Sepete Eklendi ");
                        sepet.Add("6'lı Yumurta");
                        toplam = toplam + products["6'lı Yumurta"];
                        Console.WriteLine($"Sepet Tutarı {toplam}TL");
                    break;
                    case "4":
                        Console.Write($"6'lı Margarin {products["6'lı Margarin"]} Sepete Eklendi ");
                        sepet.Add("6'lı Margarin");
                        toplam = toplam + products["6'lı Margarin"];
                        Console.WriteLine($"Sepet Tutarı {toplam}TL");
                    break;
                    case "3":
                        Console.Write($"5L Aycicek Yagi {products["5L Aycicek Yagi"]} Sepete Eklendi ");
                        sepet.Add("5L Aycicek Yagi");
                        toplam = toplam + products["5L Aycicek Yagi"];
                        Console.WriteLine($"Sepet Tutarı {toplam}TL");
                    break;
                    case "5":
                        Console.Write($"3Kg Yogurt {products["3Kg Yogurt"]} Sepete Eklendi ");
                        sepet.Add("3Kg Yogurt");
                        toplam = toplam + products["3Kg Yogurt"];
                        Console.WriteLine($"Sepet Tutarı {toplam}TL");
                    break;
                    case "6":
                        Console.Write($"1L Zeytin Yagi {products["1L Zeytin Yagi"]} Sepete Eklendi ");
                        sepet.Add("1L Zeytin Yagi");
                        toplam = toplam + products["1L Zeytin Yagi"];
                        Console.WriteLine($"Sepet Tutarı {toplam}TL");
                    break;
                    case "7":
                        Console.Write($"30'lu Yumurta {products["30'lu Yumurta"]} Sepete Eklendi ");
                        sepet.Add("30'lu Yumurta");
                        toplam = toplam + products["30'lu Yumurta"];
                        Console.WriteLine($"Sepet Tutarı {toplam}TL");
                    break;
            }

            Console.SetCursorPosition(Console.WindowWidth / 2-26, 12);
            Console.WriteLine("Sepetinizdeki Ürünler");
            for (r = 0; r < sepet.Count;r++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, 13+r);
                Console.WriteLine($"{sepet[r]}");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 26, 14 + r);
            }
            
            Console.WriteLine("Alışverişe devam etmek istiyor musunuz? E (Evet)/ H (Hayır)");
            onayB:
            string onay = Console.ReadLine();
            if (onay == "h" || onay == "H")
            {
                Console.SetCursorPosition(Console.WindowWidth/2-26, 15+r);
                Console.WriteLine("Sepetiniz: ");
                for (int i = 0; i < sepet.Count; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2, 16 + r + i);
                    Console.WriteLine(sepet[i]);
                    
                }
                Console.SetCursorPosition(Console.WindowWidth / 2, 23 + r);
                Console.Write($"Sepet Tutarı {toplam}");
            }else if (onay == "e" || onay == "E")
            {
                Console.Clear();
                goto devam;
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, 15+r);
                Console.WriteLine("Lütfen geçerli bir ifade girin..");
                goto onayB;
            }
                
                
            

            Console.ReadLine();
        }
    }
}
