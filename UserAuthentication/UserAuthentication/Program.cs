using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = null;
            string userName = null;
            string giris = "";
            int sayac = 0;

            kayitEkrani:

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi secin Giriş yapmak için G, Kayıt olmak için K tuşuna basın: ");

            giris = Console.ReadLine();
            giris = giris.ToLower();

            if (giris == "g")
            {
                Console.Clear();
                hataliBilgi:
                Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz");
                string usrName = Console.ReadLine();
                Console.WriteLine("Lütfen şifrenizi Giriniz Şifre Büyük/Küçük harf duyarlıdır");
                string pass = Console.ReadLine();
                if (userName == null)
                {
                    Console.WriteLine("Veritabanında kayıtlı böyle bir kullanıcı bulunamadı lütfen kayıt olun");
                    goto kayitEkrani;
                }
                if (usrName == userName && pass == password)
                {
                    Console.Clear();
                    Console.WriteLine($"Hoşgeldin {userName}");
                }
                else if (usrName != userName || pass != giris)
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı tekrar deneyin");
                    sayac++;
                    if (sayac == 3)
                    {
                        Console.WriteLine("Çok fazla hatalı deneme yapıldı hesabınız güvenliğiniz için geçici olarak kapatıldı lütfen gelistirici@gelistirici.com adresiyle iletisime geçin\n");
                        goto bloke;
                    }
                    goto hataliBilgi;
                    
                }
                
            }else if (giris == "k")
            {
                
                Console.WriteLine("Kullanmak istediğiniz kullanıcı adını giriniz");
                userName = Console.ReadLine();
                Console.WriteLine("Lütfen şifrenizi oluşturunuz Şifre büyük/küçük harfe duyarlıdır");
                password = Console.ReadLine();
                Console.WriteLine("Kayıt işlemi başarılı Giriş yapmak için bir tuşa basın");
                Console.ReadKey();
                Console.Clear();
                goto kayitEkrani;
                
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir ifade girin");
                goto kayitEkrani;
            }
            bloke:
            if (sayac ==3)
            {
                Console.WriteLine("Hesabınızı yeniden aktifleştirmek için gelistirici@gelistirici.com adresine mail atın");
            }
            

            Console.ReadLine();
            goto kayitEkrani;
            

        }
    }
}
