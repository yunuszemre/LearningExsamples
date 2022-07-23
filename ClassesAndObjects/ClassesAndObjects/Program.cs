using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car gtr = new Car();

            gtr.hp = 280;
            gtr.kapiSayisi = 2;
            gtr.marka = "Nissan";
            gtr.model = "GTR-R34";
            gtr.renk = "Bayside Blue";
            gtr.motorHacmi = 2.6;
            gtr.agırlık = 1450;

            Car supra = new Car(); 

            supra.hp = 280;
            supra.kapiSayisi = 2;
            supra.marka = "Toyota";
            supra.model = "Supra";
            supra.motorHacmi = 3.0;
            supra.renk = "White";
            supra.agırlık = 1435;

            Console.WriteLine($"{supra.model} vs {gtr.model}");
            Console.WriteLine($"{supra.hp} vs {gtr.hp}");
            Console.WriteLine($"{supra.motorHacmi}L vs {gtr.motorHacmi}L");
            
            Console.ReadLine();
        }
    }
}
