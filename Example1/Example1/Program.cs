using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan kullanıcının adını alıp hoşgreldin k.a şek. yaz prog.
            /*
            1. 
            */

            //Kullanıcıya girmesi gerek parametreler söylenir
            Console.WriteLine("İsiminizi Giriniz");

            //Kullanıcından gelen veri saklanır
            string fullName = Console.ReadLine();

            //Kullanıcıya Hoşgedlin mesajı gösterilir
            Console.WriteLine($"Hoşgeldin {fullName}");

            //Kullanıcının bir tuşa basması beklenir ve program kapatılır
            Console.ReadKey();

        }
    }
}
