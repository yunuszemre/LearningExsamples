using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loto
{
    public class Program
    {
        private static Random random = new Random();

        public static void Main(string[] args)
        {
            int[] lotoSayilari = new int[6];
            int cekilenSayi, sayac;

            cekilenSayi = 0;
            for (sayac = 0; sayac <= lotoSayilari.Length - 1; sayac++)
            {
                lotoSayilari[sayac] = 0;
            }
            sayac = 0;
            do
            {
                cekilenSayi = random.Next(50);
                if (LotoSayilariKontrol(cekilenSayi, lotoSayilari))
                {
                }
                else
                {
                    lotoSayilari[sayac] = cekilenSayi;
                    sayac = sayac + 1;
                }
            }
            while (sayac < 6);
            int[] kullaniciSayilari = new int[6];
            int kullaniciSayi;

            kullaniciSayi = 0;
            sayac = 0;
            for (sayac = 0; sayac <= kullaniciSayilari.Length - 1; sayac++)
            {
                kullaniciSayilari[sayac] = 0;
            }
            sayac = 0;
            do
            {
                Console.WriteLine((sayac + 1).ToString() + ". sayıyı 1-50 arasında bir değer giriniz");
                kullaniciSayi = (int)readValue();
                if (LotoSayilariKontrol(kullaniciSayi, kullaniciSayilari))
                {
                }
                else
                {
                    kullaniciSayilari[sayac] = kullaniciSayi;
                    sayac = sayac + 1;
                }
            }
            while (sayac < 6);
            sayac = 0;
            for (sayac = 0; sayac <= kullaniciSayilari.Length - 1; sayac++)
            {
                Console.Write(lotoSayilari[sayac].ToString() + "| ");
                Console.WriteLine(kullaniciSayilari[sayac].ToString() + "| ");
            }
            Console.WriteLine("Tutturulan Sayı Adeti => " + SayilarKontrol(lotoSayilari, kullaniciSayilari));
            Console.ReadLine();
        }

        public static bool LotoSayilariKontrol(int sayi, int[] lotoSayilari)
        {
            int sayac;
            bool sonuc;

            sonuc = false;
            for (sayac = 0; sayac <= lotoSayilari.Length - 1; sayac++)
            {
                if (sayi == lotoSayilari[sayac])
                {
                    sonuc = true;
                }
            }

            return sonuc;
        }

        public static int SayilarKontrol(int[] lotoSayilari, int[] kullaniciSayilari)
        {
            int tutanSayiAdet;

            tutanSayiAdet = 0;
            int sayac, icSayac, kullaniciSayi;

            sayac = 0;
            for (sayac = 0; sayac <= kullaniciSayilari.Length - 1; sayac++)
            {
                kullaniciSayi = kullaniciSayilari[sayac];
                icSayac = 0;
                for (icSayac = 0; icSayac <= lotoSayilari.Length - 1; icSayac++)
                {
                    if (kullaniciSayi == lotoSayilari[icSayac])
                    {
                        tutanSayiAdet = tutanSayiAdet + 1;
                    }
                }
            }

            return tutanSayiAdet;
        }

        // .NET can only read single characters or entire lines from the console.
        // The following function safely reads a double value.
        private static double readValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
        
    }


}


