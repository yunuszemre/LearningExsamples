using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ornekDizi = { "İstanbul", "Ankara", "İzmir", "Antalya", "Bursa", "Sivas", "İzmir" };
            string[] hedefDizi = new string[4]; 

            /*
             * Copy = Dizideki elemanları başka bir diziye kopyalar
             * Clear = Dizinin içerini tamamen veya belirli bir kısmı silmek için kullanılır
             * IndexOf = Dizi içerisinde aranan eleman varsa indexini verir yoksa -1 verir
             * LastIndexOf = IndexOf'un tersten çalışanı
             * Reverse = Diziyi terse çevirir son indexteki eleman ilk index, ilk index son index olur
             * Sort = Girilen diziyi sıralar, Özel sıralamar tanımlanabilir
             * Resize = Girilen dizinin elelman sayısını değiştirir, eleman sayısı değişen dizi orjinal dizi değildir!! --> Şerefsiz Lan Bu
             */

            //Array.Copy(ornekDizi, hedefDizi, 4 );
            //Array.Copy(ornekDizi, 2, hedefDizi, 0, 4);
            //Array.Clear(ornekDizi, 0, 4);
            //Array.Clear(ornekDizi, 0, ornekDizi.Length);

            int index = Array.IndexOf(ornekDizi, "Ankara");
            int index2 = Array.IndexOf(ornekDizi, "Sivas", 3,2);
            int index3 = Array.IndexOf(ornekDizi, "İstanbul");
            if (index != -1)
            {
                Console.WriteLine($"aranan item dizi içerisinde {index}.ci elemandır");

            }
            else
            {
                Console.WriteLine("ARanan item dizi içerisinde bulunmuyor");
            }
            Array.Reverse(ornekDizi);
            Array.Sort(ornekDizi);
            Array.Resize(ref hedefDizi, ornekDizi.Length);
            Array.Resize(ref ornekDizi, 3);
            Console.ReadKey();
        }
    }
}
