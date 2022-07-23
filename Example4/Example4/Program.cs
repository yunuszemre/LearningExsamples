using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kull alınan iki sayıyı girilen işleme göre sonc göster
            int a = 0;
            int b = 0;
            string islem = "";

            Console.WriteLine("İlk sayıyı giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi giriniz");
            islem = Console.ReadLine();

            if (islem == "+" || islem == "toplama")
            {
                Console.WriteLine($"Sonuc: {a + b}");
            }
            else if (islem == "-" || islem == "çıkarma")
            {
                Console.WriteLine($"Sonuc: {a - b}");
            }
            else if (islem == "*" || islem == "çarpma")
            {
                Console.WriteLine($"Sonuc: {a * b}");
            }
            else if (islem == "/" || islem == "bölme")
            {
                Console.WriteLine($"Sonuc: {a / b}");
            }
            else
            {
                Console.WriteLine($"Sonuc: İşlem tanınmadı");
            }
            Console.ReadLine();
        }
    }
}
