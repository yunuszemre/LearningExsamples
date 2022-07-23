using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepetUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ürün EKlee
            //ürün Listele
            //Ürün seçme
            //Sepete ekle
            //Sipariş tamamlama
            string[] product = new string[0];//ürün isimlerini tutmak için kullanılacak dizi
            decimal[] prices = new decimal[0]; //ürün fiatları için kullanılacak dizi
            int[] basket = new int[0]; // sepet için kullanılacak dizi
        main:
            do
            {
                Console.Clear();
                Console.WriteLine("Aldı alıyor.com...");
                Console.WriteLine("1-Yeni Ürün Ekleme");
                Console.WriteLine("2-Ürün Listeleme");
                Console.WriteLine("3-Ürün seçme ve sepete ekleme");
                Console.WriteLine("4-Satın alma");

                Console.Write("Lütfen Seçim Yapın..:");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        goto productAdd;
                        break;
                    case 2:
                        goto productList;
                        break;
                    case 3:
                        goto productSelectAndBasket;
                        break;
                    case 4:
                        goto buyScreen;
                        break;
                    default:

                        break;
                }

            } while (true);
        #region Ürün ekleme
        productAdd:
            ConsoleKey productAddKey;
            do
            {
                Console.Clear();
                Console.WriteLine("Lüfen Ürün adı girişi yapınız");
                string productName = Console.ReadLine();

                Console.WriteLine("Lütfen ürün fiyatını giriniz");
                decimal productPrice = decimal.Parse(Console.ReadLine());

                Array.Resize(ref product, product.Length + 1);
                product[product.Length - 1] = productName;

                Array.Resize(ref prices, prices.Length + 1);
                prices[prices.Length - 1] = productPrice;

                Console.Write("Başka ürün Eklemek ister misin yes(y), no(n)..:");

                productAddKey = Console.ReadKey().Key;

            } while (productAddKey != ConsoleKey.N);
            goto main;
        #endregion
        productList:
            #region Ürün Listeleme
            //
            Console.Clear();
            for (int i = 0; i < product.Length; i++)
            {
                string productName = product[i];
                decimal productPrice = prices[i];
                Console.WriteLine($"{i + 1}-{productName} {productPrice}tl");
            }

            Console.ReadKey();
            goto main;
        #endregion
        productSelectAndBasket:
            #region ÜrünSeçme

            do
            {

                Console.Clear();
                Console.WriteLine("*******************Sepet**********************");
                for (int i = 0; i < basket.Length; i++)
                {
                    decimal toplam = 0;
                    toplam += prices[i];
                    Console.WriteLine($"{product[i]} {prices[i]}");
                    Console.WriteLine($"Sepet Toplamı: {toplam}");
                }
                Console.WriteLine("***************Ürün Listesi*******************");
                for (int i = 0; i < product.Length; i++)
                {
                    string productName = product[i];
                    decimal productPrice = prices[i];
                    Console.WriteLine($"{i + 1}-{productName} {productPrice}tl");
                }
                Console.Write("Lütfen ürün seçimi yapınız..:");
                int urunSecme = int.Parse(Console.ReadLine());
                if (urunSecme > 0 && urunSecme <= product.Length)
                {
                    Array.Resize(ref basket, basket.Length + 1);
                    basket[basket.Length - 1] = urunSecme - 1; // kullanıcının seçtiği ürünün indexini kaydetme
                    Console.WriteLine("Başka ürün eklemek istiyor musunuz? E(evet)/h(hayır)");
                    string onay = Console.ReadLine();
                    if (onay == "e" || onay == "E")
                    {
                        goto productSelectAndBasket;
                    }
                    else
                    {
                        goto main;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen 0 dan büyük ve ekranda ki rakamlar arasında bir değer giriniz devam etmek için bir tuşa basınız");
                    Console.ReadKey();
                    goto productSelectAndBasket;
                }

            } while (true);
        buyScreen:
            Console.Clear();
            //for (int i = 0; i < basket.Length; i++)
            //{
            //    decimal toplam = 0;
            //    toplam += prices[i];
            //    Console.WriteLine($"{basket[i]} {prices[i]}");
            //    Console.WriteLine($"Sepet Toplamı: {toplam}");
            //}
            for (int i = 0; i < basket.Length; i++)
            {
                decimal toplam = 0;
                toplam += prices[i];
                Console.WriteLine($"{product[i]} {prices[i]}");
                Console.WriteLine($"Sepet Toplamı: {toplam}");
            }
            Console.WriteLine("Ödeme yöntemini seçin Kredi/Banka Kartı(kk), Havale(h), Mobil Ödeme(m)");
            string yontem = Console.ReadLine();
            switch (yontem)
            {
                case "kk":
                    Console.Clear();
                    Console.WriteLine("Kredi kartı numaranınızı giriniz");
                    string kartNo = Console.ReadLine();
                    if (kartNo.Length < 16 && kartNo.Length > 16)
                    {
                        Console.WriteLine("Lütfen 16 haneli Kart numaranızı giriniz");
                    }
                    else
                    {

                        Console.Clear();
                        Console.WriteLine("Ödeme Başarılı siparişiniz hazırlanıyor");
                        Array.Clear(basket, 0, basket.Length);
                        Array.Clear(prices, 0, prices.Length);
                        Array.Clear(product, 0, product.Length);
                        goto main;
                    }
                    break;
                case "h":
                    Console.Clear();
                    Console.WriteLine("Havale yapılacak hesap numarasını girin");
                    string hesNo = Console.ReadLine();
                    Console.Write("Ödeme Başarılı siparişiniz hazırlanıyor");
                    Array.Clear(basket, 0, basket.Length);
                    Array.Clear(prices, 0, prices.Length);
                    Array.Clear(product, 0, product.Length);
                    goto main;
                case "m":
                    Console.Clear();
                    Console.WriteLine("Ödeme yapılacak telefon numarasını girin");
                    string telNo = Console.ReadLine();
                    Console.Clear();
                    Array.Clear(basket, 0, basket.Length);
                    Array.Clear(prices, 0, prices.Length);
                    Array.Clear(product, 0, product.Length);
                    goto main;

            }

            #endregion

            Console.ReadKey();



        }
    }
}
