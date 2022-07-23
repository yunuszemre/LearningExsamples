using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ekrandan alınan isim ve soyismi mail adrsin dönş prog.
            string firstName,lastName,domain;
            
            Console.WriteLine("İsminizi Giriniz");
            firstName = Console.ReadLine();
            Console.WriteLine("Soy isminizi giriniz");
            lastName = Console.ReadLine();
            Console.WriteLine("İstediğniz mail uzantısın giriniz gmail/hotmail ");
            domain = Console.ReadLine();
            if (domain == "gmail")
            {
                Console.WriteLine($"mail adresiniz {firstName.ToLower().Trim() + lastName}@gmail.com olarak belirlenmiştir");
            }else if(domain == "hotmail")
            {
                Console.WriteLine($"mail adresiniz {firstName + lastName}@hotmail.com olarak belirlenmiştir");
            }
            else
            {
                Console.WriteLine($"lütfen gmail veya hotmail şeklinde giriş yapınız, programı yeniden başlatınız");
            }
            Console.ReadLine();
        }
    }
}
