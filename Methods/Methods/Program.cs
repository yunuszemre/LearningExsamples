using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Lütfen birinci sayıyı girin");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı girin");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int sonuc = Topla(sayi2, sayi1);

            //Console.WriteLine(sonuc);
            //SendSms("Nabiyun", "05354708229");
            Console.ReadKey();
        }

        #region GeriyeDeğerDöndürenMethodlar
        private static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        string EmailAdressConcat(string domainName, string domain)
        {
            string email = domainName + "@"+ domain;
            return email;
        }

        double Sum(double sayi1, double sayi2)
        {
            double sum = sayi1 + sayi2;
            return sum;
        }

        #endregion

        #region Void Methods
        //void Clear()
        //{
        //    Console.Clear();
        //}
        ////[parameters]
        //void Clear2(int screenParam)
        //{
        //    if (screenParam == 1)
        //    {
        //        //TODO CODE
        //    }
        //    else
        //    {
        //        //TODO CODE
        //    }
        //}

        //static void SendSms(string message, string number)
        //{
        //    //SendMessage(message);
        //} 
        #endregion
    }

}
