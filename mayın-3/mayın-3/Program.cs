using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SatırÇiz
            ////Satır Çiz
            //for (int j = 0; j <= 24; j++)
            //{
            //    if (j % 4 == 0)
            //    {
            //        Console.SetCursorPosition(0, j);
            //        for (int k = 0; k < 20; k++)
            //        {
            //            Console.Write("* ");
            //        }

            //    }
            //}
            #endregion

            #region SütunÇiz
            //Sütun Çiz
            //Console.SetCursorPosition(0, 0);
            //int yPos = 0;
            //for (int i = 0; i <= 40; i++)
            //{
            //    if (i % 8 == 0 || i == 40)
            //    {
            //        Console.SetCursorPosition(i, 0);
            //        for (int j = 0; j < 25; j++)
            //        {
            //            yPos += 1;
            //            Console.SetCursorPosition(i, yPos);
            //            Console.Write("*");
            //        }
            //        if (yPos == 25)
            //        {
            //            yPos = 0;
            //        }
            //    }
            //}
            #endregion

            int index = 0;
            int sutunIndex = 0;
            bool sayisalMi = false;
            int dısSayac;
            do
            {
                Console.WriteLine("Lütfen kaça kaçlık bir alanda oynamak istediğnizi giriniz ,3,4,5,6");
                string girdi = Console.ReadLine();
                sayisalMi = int.TryParse(girdi, out dısSayac);  
            } while (!sayisalMi);

            int icSayac = 0;
            switch (dısSayac)
            {
                case 3:
                    icSayac = 12;
                    break;
                case 4:
                    icSayac = 16;
                    break;
                case 5:
                    icSayac = 20;
                    break;
                case 6:
                    icSayac = 24;
                    break;
                case 7:
                    icSayac = 28;
                    break;
                case 8:
                    icSayac = 32;
                    break;
                case 9:
                    icSayac = 36;
                    break;
                case 10:
                    icSayac = 40;
                    break;
                case 11:
                    icSayac = 44;
                    break;
                case 12:
                    icSayac = 48;
                    break;

            }


            for (int i = 0; i <= dısSayac; i++)
            {
                Console.SetCursorPosition(0, index);
                for (int j = 0; j <= icSayac; j++)
                {
                    Console.Write("--");
                }
                index+=4;

                Console.SetCursorPosition(sutunIndex, 0);
                for (int k = 0; k <= icSayac; k++)
                {
                    Console.SetCursorPosition(sutunIndex, k);
                    Console.Write("|");
                }
                sutunIndex += 8;
            }
            
            
            Console.ReadKey();
        }
    }
}
