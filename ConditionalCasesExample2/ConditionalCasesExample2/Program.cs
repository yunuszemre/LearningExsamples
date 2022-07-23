using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalCasesExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3tamSayiKars
            int sayi1,sayi2,sayi3;
            int[] sayilar = new int[3];
            sayi1 = 1;
            sayi2 = 2;
            sayi3 = 3;
            Console.WriteLine("Birinci sayiyi giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü sayiyi giriniz");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1>sayi2 && sayi1>sayi3)
            {
                Console.WriteLine($"En büyük sayı {sayi1}");
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine($"En büyük sayı {sayi2}");
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                Console.WriteLine($"En büyük sayı {sayi3}");
            }
            Console.ReadLine();
            

            #endregion
        }
    }
}
