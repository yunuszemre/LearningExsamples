using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethoths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1-String trim = Metnin başındaki ve sonundaki boşlukları kaldırır
             * 2-string SubString = Metinin içinden parça almak için kullanılır
             * 3-string Reverse = Metni tersten sayılabilir bir array'e çevirir
             * 4-string indexOf = girilen karakterin metindeki indexini verir
             * 5-string LastIndexOf = Sondan başlayarak ındexOf un işini yapar
             * 6-Remove = metnin içinde belirli bir kısmı silmek için kullanılır
             * 7-Contains = Metnin içinde girilen ifadeyi arar
             * 8-Replace = Metnin belli bir kısmını değiştirir
             * 9-Split = Metni verilen karaktere göre parçalar, bir string dizisi döner
             * 10-ToUpper = Metnin tamamını büyük harfe çevirir
             * 11-ToLover = Metnin tamamını küçük harfe çevirir
             * 12-
             */
            #region Trim-TrimEnd-TrimStart
            string metin1 = ",  Metin1,";
            Console.WriteLine(metin1);
            Console.WriteLine(metin1.Length);
            metin1 = metin1.Trim();
            Console.WriteLine(metin1.Length);
            Console.WriteLine(metin1);
            metin1 = metin1.Trim(','); //==> Stringin başında veya sonunda "," olan yerleri kaldır
            Console.WriteLine(metin1);
            metin1 = metin1.Trim(',', 'a', 'b', '!', ' '); // ==> Stringin başında veya sonunda içerideki karakterler varsa kaldırır
            Console.WriteLine(metin1);

            //-------------------TrimEnd()------------------------- Sondaki boşluğu kaldırır.------------------TrimStart() ==> Metnin başındkai boşluğu kaldırır.
            #endregion

            #region SubString
            Console.WriteLine("***********************************/ SubString /***************************************");
            //--------------------------------------SubString----------------------------------------------------------

            string metin2 = "Yunus Emre Teke";
            Console.WriteLine(metin2);

            string metin2Parca = metin2.Substring(13, 1); //==> 13. indexten başla 1 karakter gir (13 dahil değil)

            Console.WriteLine(metin2Parca);

            Console.WriteLine(metin2.Substring(7));//==> 7. indexten başla metin sonuna kadar git 
            #endregion

            #region Reverse
            Console.WriteLine("***********************************/ Reverse /***************************************\n");
            string metin3 = "Bilge adam";

            IEnumerable<char> data = metin3.Reverse();
            Console.WriteLine("***********************************/ Reverse /***************************************\n");

            #endregion

            #region IndexOf
            Console.WriteLine("***********************************/ IndexOf /*******************************");

            string metinIndex = "emre";

            Console.WriteLine(metinIndex.IndexOf("e"));
            #endregion

            #region LastIndexOf

            Console.WriteLine("**********************************LastIndexOf*******************************");
            string metinLastIndexOf = "Merhaba";

            Console.WriteLine(metinLastIndexOf.LastIndexOf("e").ToString());
            #endregion

            #region Remove
            Console.WriteLine("******************************/ Remove /****************************");
            string metinRemove = "Bugün hava çok güzel";

            Console.WriteLine(metinRemove.Remove(7));

            Console.WriteLine(metinRemove.Remove(5, 13));
            #endregion

            #region Odev
            //int counter = 0;
            //int index = 0;
            //string paragraf = "lşsknaglikankjsegınlaiksrnlkinskilngpeiongljşinailskngilknaslking";
            //do
            //{

            //    index++;
            //} while (index != paragraf.Length);

            //Console.WriteLine(counter); 
            #endregion

            #region Contains

            Console.WriteLine("**************************************Contains************************");
            string metinContains = ("Bilge adam");

            bool containsResult=metinContains.Contains('e');

            Console.WriteLine(containsResult);
            #endregion

            #region Replace
            Console.WriteLine("********************************/ REplace /***************************");

            string replace = "Bugün hava cok cok güzel";

            string replaced = replace.Replace("cok", "az");

            Console.WriteLine(replace+ " "+ replaced);
            #endregion

            #region SPlit
            Console.WriteLine("*****************************Split******************************");
            string splitMetin = "Bugün hava çok güzel";

            string[] result = splitMetin.Split(' ');
            Console.WriteLine(result);
            #endregion

            #region ToLower-ToUpper
            Console.WriteLine("*****************************ToLower-ToUpper******************************");
            string yazi = "BilgeAdam";

            string büyükYazi = yazi.ToUpper();
            string kücükYazi = yazi.ToLower();

            Console.WriteLine($"{büyükYazi} {kücükYazi}");
            #endregion









            Console.ReadKey();
        }
    }
}
