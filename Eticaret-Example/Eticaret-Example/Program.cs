using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = new string[0];
            decimal[] prices = new Decimal[0];
            int[] basket = new int[0];
            decimal toplam = 0;
        main:
            Console.Clear();

            Console.WriteLine("1. Ürün Ekleme");
            Console.WriteLine("2. Ürün Listeleme");
            Console.WriteLine("3. Alışveriş-Sepete Ekleme");
            Console.WriteLine("4- Ödeme-Sepet Kontrol");

            Console.Write("Lütfen yapmak istediğiniz işlemin numarasını giriniz..: ");
            ConsoleKey key1 = Console.ReadKey().Key;
            switch (key1)
            {
                case ConsoleKey.D1:
                    goto productAdd;
                    break;
                case ConsoleKey.D2:
                    goto productListing;
                    break;
                case ConsoleKey.D3:
                    goto addBasket;
                    break;
                case ConsoleKey.D4:
                    goto odeme;
                    break;
                default:
                    Console.Clear();
                    goto main;
                    break;
            }

        productAdd:

            do
            {


                Console.Clear();
                Console.Write("Lütfen EKlemek istediğiniz ürünün adını giriniz..:");
                string productName = Console.ReadLine();
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = productName;
                Console.Write("Lütfen Eklediğiniz ürünün fiyatını giriniz..:");
                decimal price = decimal.Parse(Console.ReadLine());
                Array.Resize(ref prices, prices.Length + 1);
                prices[prices.Length - 1] = price;


                Console.Write("Yeni ürün eklemek istiyor musunuz Y(yes) N(no)");


            } while (Console.ReadKey().Key != ConsoleKey.N);

            goto main;

        productListing:
            Console.Clear();
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{products[i]} {prices[i]}");
            }

            bool control = false;

            do
            {
                Console.WriteLine("Ana menüye gitmek için ESC tuşuna basın");
                ConsoleKey key2 = Console.ReadKey().Key;
                if (key2 == ConsoleKey.Escape)
                {
                    control = true;
                    goto main;
                }
            } while (!control);

        addBasket:
            bool decimalMi = false;
            int ürün;
           
            do
            {

                Console.Clear();
                Console.WriteLine("Sepetiniz...:");
                for (int i = 0; i < basket.Length; i++)
                {

                    int productIndex = basket[i];
                    int priceIndex = basket[i];
                    Console.WriteLine($"{products[productIndex]} {prices[priceIndex]}");
                    toplam += prices[priceIndex];
                }
                Console.WriteLine($"Sepet Toplamı..: {toplam}\n");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i]} {prices[i]}");
                }

                Console.WriteLine("Eklemek istediğiniz ürünün numarasını giriniz..:");

                string product = Console.ReadLine();
                decimalMi = int.TryParse(product, out ürün);
                if (ürün > 0 && ürün <= products.Length)
                {
                    Array.Resize(ref basket, basket.Length + 1);
                    basket[basket.Length - 1] = ürün - 1;

                }
                Console.Write("Yeni ürün eklemek istiyor musunuz Y(yes) N (no)..");
                string onay = Console.ReadLine();
                if (onay == "y")
                {
                    goto addBasket;
                }
                else
                {
                    decimalMi = false;
                }

            } while (decimalMi);
            goto main;

        odeme:
            Console.Clear();
            Console.WriteLine("Sepetiniz...:");
            for (int i = 0; i < basket.Length; i++)
            {

                int productIndex = basket[i];
                int priceIndex = basket[i];
                Console.WriteLine($"{products[productIndex]} {prices[priceIndex]}");

            }
            Console.WriteLine($"Sepet Toplamı..: {toplam}\n");
            if (toplam >= 10000)
            {
                Console.WriteLine($"Tebrikler sepet tutarınız 10.000Tl üzeri olduğu için %10 indirim kazandınız indirimli sepet tutarınz..: {toplam * 0.9m}");
            }
            else if (toplam >= 5000)

            {
                Console.WriteLine($"Tebrikler sepet tutarınız 5.000Tl üzeri olduğu için %5 indirim kazandınız indirimli sepet tutarınz..: {toplam * 0.95m}");
            }
            else if (toplam >= 1000)
            {
                Console.WriteLine($"Tebrikler sepet tutarınız 1.000Tl üzeri olduğu için %1 indirim kazandınız indirimli sepet tutarınz..: {toplam * 0.99m}");
            }
            else if (toplam >= 500)
            {
                Console.WriteLine(
                    $"Tebrikler sepet tutarınız 500Tl üzeri olduğu için ikinci alışverişinizde geçerli 20tl indirim kuponu kazandınız\n");
            }
            Console.WriteLine($"Ödeme yapmak istiyorsanız E istemiyorsanız H tuşuna basın");
            string odemeOnay = Console.ReadLine();
            if (odemeOnay == "e")
            {
                Console.Clear();
                Console.WriteLine("Ödeme başarılı siparişiniz hazırlanıyor");
                Array.Resize(ref products, 0);
                Array.Resize(ref prices, 0);
                Array.Resize(ref basket, 0);
            }
            else
            {
                goto main;
            }

            Console.ReadKey();

        }
    }
}
