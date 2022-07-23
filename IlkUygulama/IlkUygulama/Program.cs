using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulama
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.Write("İsiminizi Giriniz: ");
            Console.WriteLine(HelloWorld(message: Console.ReadLine()));
            Console.ReadKey();
            String HelloWorld(string message)
            {
                message =$"Hoşgeldin {message.ToUpper()}";
                return message;
                /*
                Using
                Namespace
                scope
                Write & WriteLine
                */
            }

        }
        

    }

}
