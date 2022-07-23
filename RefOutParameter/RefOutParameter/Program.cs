using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 1;
            int sayi2 = 13;
            DegerDegistir(sayi1,sayi2);
            Console.ReadKey();
        }

        public static void DegerDegistir(int deger1, int deger2)
        {
            int temp = deger1;
            deger1 = deger2;
            deger2 = temp;
            Console.WriteLine($"{deger1} {deger2}");
            Hesaplama hesaplama = new Hesaplama();
            hesaplama.Sayi1 = 20;
            hesaplama.Sayi2 = 10;
            DegerDegistir2(hesaplama);

        }

        public static void DegerDegistir2(Hesaplama hesaplama)
        {
            int temp = hesaplama.Sayi1;
            hesaplama.Sayi1 = hesaplama.Sayi2;
            hesaplama.Sayi2 = temp;
            Console.WriteLine($"{hesaplama.Sayi1} {hesaplama.Sayi2}");
        }
    }

    public class Hesaplama
    {
        private int _sayi1;

        public int Sayi1
        {
            get { return _sayi1; }
            set { _sayi1 = value; }
        }
        private int _sayi2;

        public int Sayi2
        {
            get { return _sayi2; }
            set { _sayi2 = value; }
        }

    }
}
