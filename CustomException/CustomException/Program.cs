using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Lütfen 0-100 arasında bir sayi giriniz");
                int sayi = int.Parse(Console.ReadLine());

                SayiContol contol = new SayiContol();
                contol.Kontol(sayi);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("İstenilen");
            }
            Console.ReadLine();

        }
    }

    public class SayiContol
    {
        public void Kontol(int sayi)
        {
            if (sayi > 100 || sayi < 0)
            {
                throw new HatasizKulOlmaz("Sayı aralığında değer girişi yapmadınız");
            }
        }
    }
}
