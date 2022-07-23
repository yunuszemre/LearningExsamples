using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //************************----Ref----**************************

            // ref parametresi stack içerisindeki farklı değişkenlerin heap belek içerisinde aynı adresteki değerde işlem yapılmasını sağlar 
            // ref paraemtresi her veri tipinde çalışır
            // ref parametresi kullanılırken değişkenin ilk değeri atanmış olmalıdır

            int a = 5;
            int b = a;
            Arttır(a);
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine(b);
            Console.WriteLine(a);
            ref int c = ref a;

            Console.WriteLine(c);
            Arttır(ref a);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Arttır(ref c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(intArray.Length);

            ArrayResize(ref intArray, 10);
            Console.WriteLine(intArray.Length);
            //intArray[^1] = 11;
            
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            Console.ReadKey();
            
            
        }
        private static void Arttır(int deger)
        {
           deger += 5;
        }
        private static void Arttır(ref int deger)
        {
            deger += 5;
        }
        static void ArrayResize(ref int[] arr, int lenght)
        {
            int[] newArray = new int[arr.Length];
            
            for(int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }

            arr = new int[lenght];

            for (int i = 0; i < newArray.Length; i++)
            {
                arr[i] = newArray[i];
            }

        }
    }
}
