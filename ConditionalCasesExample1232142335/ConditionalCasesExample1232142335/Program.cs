using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalCasesExample1232142335
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Kullanıcıdan alınan ifade kasım-aralık-ocak

            tekrarGiris: 
            Console.WriteLine("Olduğunuz ayı giriniz");
            string ay = Console.ReadLine();
            string mevsim = "";

            switch (ay)
            {
                case "ocak":
                case "kasım":
                case"aralık":
                {
                    mevsim = "Kış"; 
                    break;
                }
                case "şubat":
                case "mart":
                case "nisan":
                {
                    mevsim = "ilkbahar";
                    break;
                }
                case "mayıs":
                case "haziran":
                case "temmuz":
                {
                    mevsim = "Yaz";
                    break;
                }
                case "ağustos":
                case "eylül":
                case "ekim":
                {
                    mevsim = "Sonbhar";
                    break;
                }

                default:
                    Console.WriteLine("Ay bilgisi anlaşılamadı");
                    break;
            }

            Console.WriteLine($"Olduğunuz mevsim: {mevsim}");
            Console.WriteLine("Yeni bir ay bilgisi girmek ister misiniz? E (Evet)/H (Hayır)");
            string giris = Console.ReadLine();
            if (giris == "E" || giris == "e")
            {
                goto tekrarGiris;
            }
            else if(giris == "h" || giris == "H")
            {
                Console.WriteLine("Uygulama sonlanıyor");
                Environment.Exit(0);
            }
            Console.ReadLine();

        }
    }
}
