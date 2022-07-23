using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalCasesExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Başla
             * sayi değişkenini oluştur
             * kullanıcıya bir sayı girmesini söyle
             * Kullanıcıdan sayı değişkenini al
             * sayı%2 = 0 mı kontrol et true sa 6. adıma git false sa 7. adıma git
             *sayı = sayı/2 işlemini yap 
             * sayı = sayı*2 işlemini yap
             * ekrana sayı değişkenini yazdır
             * bitir
             */
            decimal sayi = 0;
            Console.WriteLine("Lütfen bir sayi giriniz");
            sayi = decimal.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
                sayi = sayi / 2;
            else
                sayi = sayi * 2;
            Console.WriteLine(sayi);
            Console.ReadLine();


        }
    }
}
