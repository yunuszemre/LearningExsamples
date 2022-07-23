using System;

namespace OpsiyonelParametreliMethodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NameAndAge("Yunus", 23);//Her iki parametre de zorunlu
            //string name_age = NameAndAgeOptional("Yunus");//age parametresi opsiyonel olduğu için gönd. olur gönderesen de

            //Console.WriteLine(name_age);
            //NameAndAge(age: 34, name: "Emre"); // Karışık sıralı parametre verme
            do
            {
                int sayi = int.Parse(Console.ReadLine());
                int toplam = Topla(sayi);
                Console.WriteLine(toplam);
            } while (true);

            Console.ReadLine();
        }

        //static string NameAndAge(string name, int age)
        //{
        //    return $"Adı: {name} Yaşı: {age}";
        //}

        //static string NameAndAgeOptional(string name, int age = 23)
        //{
        //    return $"Adı: {name} Yaşı: {age}";
        //}

        static int Topla(int sayi, int toplam = 0)
        {
            toplam += sayi;
            return toplam;
        }
    }

}
