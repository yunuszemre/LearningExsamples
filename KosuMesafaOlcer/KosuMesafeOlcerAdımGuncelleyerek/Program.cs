using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosuMesafeOlcerAdımGuncelleyerek
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double distance = 0;
            int[] stepLenghts = new int[0];
            int stepLenght = GetStepLenght();
            int stepCount = GetStepCount();
            int runTimeHours = GetRunTimeHours();
            int runTimeMinutes = GetRunTimeMinutes();
            int islem = Menu();
            if (islem == 1)
            {
                UpdateStepLenght(ref stepLenghts);
                double averageStepLenght = CalculateAvarageStepLenght(ref stepLenghts);
                distance = CalculateRunDistance(averageStepLenght, runTimeHours, runTimeMinutes, stepCount);
            }
            else
            {
                distance = CalculateRunDistance(runTimeHours, runTimeMinutes, stepLenght, stepCount);
            }
            Console.WriteLine($"Toplamda {distance}m koştunuz");
            Console.ReadLine();
        }

        private static int GetStepLenght() // Koşu öncesinde kullanıcının adım mesafesi alınır
        {
            int lenght = 0;
            bool isDigit = false;
            int errorCount = 0;
            do
            {
                if (errorCount > 0)
                {
                    Console.WriteLine("Lüfen sayısal ifade giriniz");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out lenght);
                }
                else
                {
                    Console.WriteLine("Lütfen koşuya başlamadan önce adım boyunuzu giriniz");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out lenght);
                    errorCount++;
                }
            } while (!isDigit);

            return lenght;
        }
        private static int GetStepCount() //dakikada kaç adım attığı bilgisi alınır
        {
            int stepCount = 0;
            bool isDigit = false;
            int errorCount = 0;
            do
            {
                if (errorCount > 0)
                {
                    Console.WriteLine("Lüfen sayısal ifade giriniz");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out stepCount);
                }
                else
                {
                    Console.WriteLine("LÜtfen koşuya başlamadan önce bir dakikada kaç adım attığınızı giriniz");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out stepCount);
                    errorCount++;
                }
            } while (!isDigit);

            return stepCount;
        }
        private static int GetRunTimeHours() //Kullanıcıdan kaç saat koşmak istediği bilgisi alınır
        {
            int hours;
            bool isDigit = false;
            int errorCount = 0;
            do
            {
                if (errorCount > 0)
                {
                    Console.WriteLine("Lüfen sayısal ifade giriniz");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out hours);
                }
                else
                {
                    Console.WriteLine("Lütfen koşuya başlamadan önce kaç saat koşacağınızı giriniz");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out hours);
                    errorCount++;
                }
            } while (!isDigit);
            return hours;
        }
        private static int GetRunTimeMinutes() // Kullanıcıdan kaç dakika koşmak istediğ bilgisi alınır
        {

            int minutes;
            bool isDigit = false;
            int errorCount = 0;
            do
            {

                if (errorCount > 0)
                {
                    Console.WriteLine("Lüfen sayısal ifade giriniz");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out minutes);
                }
                else
                {
                    Console.WriteLine("Kaç dakika koşacağınızı giriniz, bu değer saat veriniz ile toplanıp işlenme alınacaktır");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out minutes);
                    errorCount++;
                }

            } while (!isDigit);
            return minutes;
        }

        private static double CalculateRunDistance(int hour, int minute, int stepLenght, int stepCount)//sabit adım uzunluğunda koşulan mesafe hesaplaması
        {
            int time = (hour * 60) + minute;

            double distance = ((time * stepCount * (stepLenght * 0.01)));

            return distance;

        }
        private static int UpdateStepLenght(ref int[] stepLenghts)//Koşu esnasında adım sayısı güncellenmek isteniyorsa yeni adım sayısı alma
        {

            int lenght = 0;
            bool isDigit = false;
            int errorCount = 0;
            string onay = "";
            do
            {
                if (errorCount > 0 && onay != "e" || onay == "E")
                {
                    Console.WriteLine("Lüfen sayısal ifade giriniz");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out lenght);
                }
                else
                {
                    Console.Write("Lütfen yeni adım uzunluğunuzu girin..:");
                    string input = Console.ReadLine();
                    isDigit = int.TryParse(input, out lenght);
                    Console.WriteLine("Adım sayınızı tekrar güncellemek istiyor musunuz? E(Evet) H(Hayır)");
                    onay = Console.ReadLine();
                    if (onay != "e" || onay != "E")
                    {

                    }
                    errorCount++;
                }
                Array.Resize(ref stepLenghts, stepLenghts.Length + 1);
                stepLenghts[stepLenghts.Length - 1] = lenght;
            } while (!isDigit || onay == "e" || onay == "E");

            return lenght;
        }
        private static double CalculateAvarageStepLenght(ref int[] stepLenghts)//Koşu esnasında adım uzunluğu değiştiyse ortalama adım uzunluğu hesaplama
        {
            double steplenght = 0;
            double averageLenght = 0;
            foreach (int lenght in stepLenghts)
            {
                steplenght += lenght;
            }
            averageLenght = steplenght / stepLenghts.Length;
            return averageLenght;
        }
        private static double CalculateRunDistance(double averageStepLenght, int hour, int minute, int stepCount)//Sabit hızda koşulduğunda toplam koşulan mesafe hesaplama
        {
            double distance = 0;
            int time = (hour * 60) + minute;
            distance = (time * stepCount * (averageStepLenght * 0.01));
            return distance;
        }
        private static int Menu()//Koşu esnasında adım uzunluğunu değiştirmek istiyor mu yoksa sabit hızda mmı koşuyor sorgusu
        {
            bool isDigit = false;

            int islem;
            do
            {

                
                Console.WriteLine("1- Adım Boyu Güncelle");
                Console.WriteLine("2- Sonuç Göster");

                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz..:");
                isDigit = int.TryParse(Console.ReadLine(), out islem);

                if (islem < 1 || islem > 2)
                {
                    Console.WriteLine("Lütfen 1-2 arasında bir değer girin");
                }
                

            } while (!isDigit || islem < 1 || islem > 2);
            return islem;
        }


    }

}
