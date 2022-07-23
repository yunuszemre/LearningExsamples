using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuth_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "admin";
            string password = "123";
            int sayac = 0;
            Random random = new Random();
            byte[] bytes = new byte[1024];

            #region UserAuth
            //tekrarDeneyin:

            //    Console.WriteLine("Kullanıcı adınızı giriniz");
            //    string usrName = Console.ReadLine().ToLower();
            //    Console.WriteLine("Şifrenizi Giriniz");
            //    string pass = Console.ReadLine().ToLower();

            //    if (usrName == userName && pass == password)
            //    {
            //        Console.WriteLine($"Giriş başarılı hoşgeldin {usrName}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı kullanıcı adı veya şifre tekrar deneyin");
            //        sayac++;
            //        if (sayac < 3)
            //        {

            //            goto tekrarDeneyin;
            //        }
            //        else
            //        {
            //            Console.Write("Çok fazla hatalı deneme yapıldı hesabınız bloke edildi");
            //        } 
            #endregion
            random.NextBytes(bytes);
            
            foreach (var VARIABLE in bytes)
            {
                Console.WriteLine(bytes[VARIABLE]);
            }
            Console.ReadLine();

        }
            

            

            
        
    }
}
