using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kulanıcıdan alınan  sayının ort., Convert.ToSingle()=> floata dönşş.
            List<double> list = new List<double>();
            double top = 0;
            double ort = 0;
            for (int i = 0; i < 5; i++)
            {
                double z = 0; 
                Console.WriteLine($"Ortalamasını almak istediğiniz sayılardan {i+1}. sini giriniz");
                z = Convert.ToDouble(Console.ReadLine());
                list.Add(z);
                
                
            }
            for (int i = 0; i < list.Count; i++)
            {
                top = top + list[i];
                ort = top / list.Count;

            }
            Console.WriteLine($"sayıların ortalaması {ort}");

            //double a = 0;
            //double b = 0;
            //double c = 0;
            //double d = 0;
            //double e = 0;
            //Console.WriteLine("5 sayı giriniz sayiyi giriniz");
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());
            //c = Convert.ToDouble(Console.ReadLine());
            //d = Convert.ToDouble(Console.ReadLine());
            //e = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"sayıların ortalaması {(a + b + c + d + e) / 5}");
            Console.ReadLine();


        }
    }
}
