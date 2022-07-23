using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icecekOtomati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            baslangic:
            Console.Clear();
            #region MeyveSuyuIf-Else

            string harf = "";

            Console.WriteLine("Lütfen almak istediğiniz ürünü kodunu girin");
            Console.WriteLine("Ç: Çay");
            Console.WriteLine("L: Limonata");
            Console.WriteLine("M: Meyve suyu");
            Console.WriteLine("K: Kola");
            Console.WriteLine("B: Bisküvi");

            harf = Console.ReadLine();

            //if (harf == "ç")
            //{
            //    Console.WriteLine("Çay aldınız");
            //}
            //else if (harf == "l")
            //{
            //    Console.WriteLine("Limonata aldınız");
            //}
            //else if (harf == "m")
            //{
            //    Console.WriteLine("Meyve suyu aldınız");
            //}
            //else if (harf == "k")
            //{
            //    Console.WriteLine("Kola aldınız");
            //}
            //else if (harf == "b")
            //{
            //    Console.WriteLine("Bisküvi aldınız");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen ekranda gördüğünüz kodlardan birini giriniz");
            //}
            #endregion

            #region MeyveSuyuSwitch

            switch (harf)
            {
                case "ç":
                {
                    Console.WriteLine("Çay");
                    break;
                }
                case "l":
                {
                    Console.WriteLine("Limonata");
                    break;
                }
                case "m":
                    Console.WriteLine("Meyve Suyu");
                    break;
                case "k":
                    Console.WriteLine("Kola");
                    break;
                case "b":
                    Console.WriteLine("Bisküvi");
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    goto baslangic;
                    
                    break;
            }
            #endregion
            Console.ReadLine();
        }
    }
}
