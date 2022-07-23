using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalCasesExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tek çift
            #region TekCift

            decimal sayi = 0;
            Console.WriteLine("Lütfen bir sayi giriniz");
            sayi = decimal.Parse(Console.ReadLine());
            if (sayi%2 == 0)
            {
                Console.WriteLine($"{sayi} Sayısı çifttir");
            }
            else
            {
                Console.WriteLine($"{sayi} Sayısı tektir");
            }


            #endregion

            Console.ReadLine();
        }
    }
}
