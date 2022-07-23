using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneKavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nesne: Gerçek yaşamdaki şeyleri yazılıma aktarmak için classlar kullanılarak oluşturulan yapılar
            try
            {
                Bird papagan = new Bird();
                papagan.Renk = "Kırmızı";
                Bird muhabbetKusu = new Bird();
                muhabbetKusu.Renk = "Mavi";
                muhabbetKusu.Yas = 2;
                //papagan.Yas = 15;
                papagan.Yas = 5;
                //papagan.Fly();
                //muhabbetKusu.Fly();

                Car rs3 = new Car();
                rs3.EngineLiter = 2.5;
                rs3.ProductYear = "2018";
                rs3.BodyType = "Hatchback";
                rs3.Color = "Red";
                rs3.Fuel = "Petrol";
                rs3.HorsePower = 400;
                rs3.Weight = 1650;
                rs3.Producer = "AUDI";
                rs3.Model = "RS3";
                rs3.Segment = "C";
                rs3.Traction = "AWD";
                rs3.TransmissionType = "Auto";
                rs3.SpeedCount = 6;
                rs3.CylinderCount = 5;
                rs3.Torque = 500;

                Car m3Comp = new Car();
                m3Comp.HorsePower = 510;
                m3Comp.Torque = 650;
                m3Comp.EngineLiter = 3;
                m3Comp.Weight = 1780;
                m3Comp.CylinderCount = 6;
                m3Comp.ProductYear = "2022";
                m3Comp.SpeedCount = 6;
                m3Comp.TransmissionType = "Auto";
                m3Comp.BodyType = "Sedan";
                m3Comp.Fuel = "Petrol";
                m3Comp.Color = "Green";
                m3Comp.Producer = "BMW";
                m3Comp.Model = "M3";
                m3Comp.Segment = "C";
                m3Comp.Traction = "RWD";
                m3Comp.Acceleration(m3Comp.Weight, m3Comp.Torque);
                
                Computer computer1 = new Computer();
                computer1.Manufacturer = "Monster";
                computer1.Model = "Abra A5V16.6";
                computer1.Type = "Laptop";
                computer1.IntegratedKeyboard = true;
                computer1.IntegratedKeyboardBacklight = true;
                computer1.PriceCalculate(computer1.Price, 8, "i3", 256);
                Console.WriteLine($"{computer1.Manufacturer} marka {computer1.Model} bilgisayarın fiyatı {computer1.Price}");



                //Console.WriteLine(rs3.ProductYear);
                //Console.WriteLine(papagan.Yas);
                rs3.Acceleration(rs3.Weight, rs3.HorsePower, rs3.Torque);
                //Console.WriteLine(papagan.Renk);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            Console.ReadKey();

        }

       
    }
}
