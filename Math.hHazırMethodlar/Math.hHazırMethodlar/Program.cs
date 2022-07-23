using System;


internal class Program
    {
        static void Main(string[] args)
        {
        /*
         * Math <--> .Net içindeki hazır matetiksel methodlar
         * PI = 
         * Abs = Girilen sayının mutlak değerini alır
         * Ceiling = Girilen ondalıklı sayıyı yukarı yuvarlar
         * Floor = Girilen ondalıklı sayıyı aşağı yuvarlar
         * Round = Girilen ondalıklı sayıyı en yakın sayıya yuvarlar
         * Cos = Girilen Değerin Cosinüs değerini verir
         * Tan = Girilen Değerin Tanjant değerini verir
         * Cot = Girilen Değerin Cotanjant değerini verir
         * Sin = Girilen Değerin Sinüs değerini verir
         * Max =
         * Min =
         * Sqrt = Girilen sayının karekökünü alır
         * Pow = Girilen sayının (a girilen sayı, b kuvvet) a üssü b şeklinde kuvvetini alır
         * Truncate = Girilen ondalıklı sayının tam kısmını verir
         * Log = Girilen sayının Log e tabanında karşılığını verir
         */
        Console.WriteLine(Math.Cos(1));
        Console.WriteLine(Math.PI);
        int left = Console.CursorLeft;
        int top = Console.CursorTop;

        do
        {
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.RightArrow)
            {
                left++;
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                if (left > 1)
                    left--;
            }

            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.Write("Emre Özbaşkan");

        } while (true);
        Console.ReadKey();
        }
    }

