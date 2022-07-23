using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParametresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **********************--Out--****************************
            // Out parmetresi ile ref parametresinin farkı değişken değeri ön tanımlı değildir, değişkene başlangıç değeri verilmek zorunda değildir
            // Out kullanırken değerin başlangıç değeri kendi içinde belirlenir
            int a;
            bool b;
            Arttır(out a);
            Console.WriteLine(a);
            b = FakeTryParse("123", out a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
        static void Arttır(out int deger)
        {
            deger = 0;
            deger += 5;
        }
        private static int islem()
        {
            int a = 0;
            return a;
        }
        private static bool FakeTryParse(string s, out int a)
        {
            bool result = false;
            a = 0;

            try
            {
                a = Convert.ToInt32(s);
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            return result;
        }
    }
}
