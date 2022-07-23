using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosuMesafaOlcer
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int stepLenght = GetStepLenght();
            int stepCount = GetStepCount();
            int runTimeHours = GetRunTimeHours();
            int runTimeMinutes = GetRunTimeMinutes();
            double distance = CalculateRunDistance(runTimeHours, runTimeMinutes, stepLenght, stepCount);

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
        //Kullanıcının ne kadar koştuğu hesaplanır
        private static double CalculateRunDistance(int hour, int minute, int stepLenght, int stepCount)
        {
            int time = (hour * 60) + minute;

            double distance = ((time * stepCount * (stepLenght * 0.01)));

            return distance;

        }


    }
}
