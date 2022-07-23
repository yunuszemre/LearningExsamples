using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Method_Eample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personalGradeArray = new string[] { "prof", "Doc", "Ögr. gör" };
            string[] personalNameArray = new string[] { "Murat", "Serkan", "Ahmet Türker" };
            string[] personalLastNameArray = new string[] { "Bursal", "Buldur", "Tüzemen" };
            string[] personalDepartmentArray = new string[] { "Fen", "Fen", "Fen" };
            string[] personalEmailArray = new string[] { ",", ",0", "," };
            DateTime[] personalLastDateArray = new DateTime[0];
        menu:
            Console.Clear();
            Menu();

            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    goto Add;
                    break;
                case "2":
                    goto Listing;
                    break;
                case "3":
                    goto ListingTenDaysRemaining;
                    break;
                case "4":
                    goto PersonelUpdate;
                    break;
            }

        Add:
            do
            {
                Console.Clear();
                bool exceptionHandled = false;

                //PersonalNameAdd(ref personalNameArray);

                //PersonalLastameAdd(ref personalLastNameArray);

                //PersonalDepartmentAdd(ref personalDepartmentArray);

                PersonalLastDateAdd(ref personalLastDateArray, exceptionHandled);

                //PersonalGradeAdd(ref personalGradeArray);

                //PersonalEmailAdd(ref personalEmailArray);

                Console.Write("Yeni personel eklemek istiyor musunuz? E(Evet) H(Hayır)..:");
                string onay = Console.ReadLine();
                if (onay == "e")
                {
                    goto Add;
                }
                else
                {
                    goto menu;
                }

            } while (true);
        Listing:
            do
            {
                Console.Clear();
                ListPersonel(ref personalGradeArray, ref personalNameArray, ref personalLastNameArray, ref personalDepartmentArray, ref personalLastDateArray, ref personalEmailArray);

                Console.ReadKey();
                goto menu;
            } while (true);
        ListingTenDaysRemaining:
            do
            {
                ListLessThenTenDaysAndLessThan30Days(ref personalGradeArray, ref personalNameArray, ref personalLastNameArray, ref personalDepartmentArray, ref personalLastDateArray, ref personalEmailArray);
                int index = SelectUpdatePersonelAgreement();
                UpdatePersonelAgreement(index, personalLastDateArray);
                Console.ReadKey();
            } while (true);
        PersonelUpdate:
            do
            {
                UpdatePersonelAgreement(SelectUpdatePersonelAgreement(), personalLastDateArray);
            } while (true);
        }

        public static void Menu()
        {
            Console.WriteLine("1-Personel Ekleme");
            Console.WriteLine("2-Personel Listesi");
            Console.WriteLine("3-Personel Listleme");
            Console.WriteLine("4-Personel Güncelleme");
            Console.WriteLine("5-Personel Silme");
            Console.Write("Lütfen yapmak istediğiniz işlemin işlem numarasını giriniz..:");
        }

        public static void PersonalNameAdd(ref string[] arr)
        {
            Console.Write("Lütfen eklemek istediğiniz personelin adını giriniz..:");
            string firstName = Console.ReadLine();
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = firstName;

        }
        public static void PersonalLastameAdd(ref string[] arr)
        {
            Console.Write("Lütfen eklemek istediğiniz personelin soyadını giriniz..:");
            string lastName = Console.ReadLine();
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = lastName;

        }
        public static void PersonalDepartmentAdd(ref string[] arr)
        {
            Console.Write("Lütfen eklemek istediğiniz personelin görev aldığı bölümü giriniz..:");
            string department = Console.ReadLine();
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = department;

        }
        public static void PersonalGradeAdd(ref string[] arr)
        {
            Console.Write("Lütfen eklemek istediğiniz personelin akademik ünvanını giriniz..:");
            string grade = Console.ReadLine();
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = grade;
        }
        public static void PersonalEmailAdd(ref string[] arr)
        {
            Console.Write("Lütfen eklemek istediğiniz personelin e-posta adresini giriniz..:");
            string email = Console.ReadLine();
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = email;

        }
        public static void PersonalLastDateAdd(ref DateTime[] arr, bool condition)
        {
            Console.Write("Lütfen eklemek istediğiniz personelin sözleşme bitiş tarihini aa.gg.yy şeklinde giriniz..:");
            try
            {
                DateTime agreementLastDateTime = DateTime.Parse(Console.ReadLine());
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = agreementLastDateTime;
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                condition = true;
            }
            if (condition)
            {
                Console.WriteLine("Tekrar giriş yapmak için bir tuşa basın..:");
                Console.ReadKey();
                //goto here;
            }

        }
        static void ListPersonel(ref string[] gradeArray, ref string[] personelNameArray, ref string[] personelLastNameArray, ref string[] personelDepartmentArray, ref DateTime[] agreementDateArray, ref string[] personelEmailArray)
        {
            Console.Clear();
            for (int i = 0; i < gradeArray.Length; i++)
            {
                Console.WriteLine($"{gradeArray[i]}. Dr. {personelNameArray[i]} {personelLastNameArray[i]} {personelDepartmentArray[i]} Sözleşme Bitiş Tarihi: {agreementDateArray[i]} E-mail: {personelEmailArray[i]}");
            }
        }

        static void ListLessThenTenDaysAndLessThan30Days(ref string[] gradeArray, ref string[] personelNameArray, ref string[] personelLastNameArray, ref string[] personelDepartmentArray, ref DateTime[] agreementDateArray, ref string[] personelEmailArray)
        {
            Console.Clear();
            for (int i = 0; i < agreementDateArray.Length; i++)
            {

                TimeSpan kalan = agreementDateArray[i].Subtract(DateTime.Now);

                if (kalan.TotalDays < 10)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Şözleşmelerinin bitimine 10 günden az kalan personeller");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{i + 1}. {gradeArray[i]}. Dr. {personelNameArray[i]} {personelLastNameArray[i]} {personelDepartmentArray[i]} Sözleşme Bitiş Tarihi: {agreementDateArray[i]} E-mail: {personelEmailArray[i]} Kalan gün: {Math.Ceiling(kalan.TotalDays)}");
                }
                else if (kalan.TotalDays < 30)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Şözleşmelerinin bitimine 1 aydan az kalan personeller");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{i + 1}. {gradeArray[i]}. Dr. {personelNameArray[i]} {personelLastNameArray[i]} {personelDepartmentArray[i]} Sözleşme Bitiş Tarihi: {agreementDateArray[i]} E-mail: {personelEmailArray[i]} Kalan gün: {Math.Ceiling(kalan.TotalDays)}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {gradeArray[i]}. Dr. {personelNameArray[i]} {personelLastNameArray[i]} {personelDepartmentArray[i]} Sözleşme Bitiş Tarihi: {agreementDateArray[i]} E-mail: {personelEmailArray[i]} Kalan gün: {Math.Ceiling(kalan.TotalDays)}");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static int SelectUpdatePersonelAgreement(int index = 0)
        {
            Console.Write("Sözleşmesini güncellemek istediğiniz personel ID'sini girin..: Güncelleme yapmadan ana menüye gitmek için ESC tuşuna basın ");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Escape)
            {
                Menu();
            }
            else
            {
                index = int.Parse(Console.ReadLine()) - 1;
            }
            

            return index;
        }
        static void UpdatePersonelAgreement(int index, DateTime[] arr)
        {
            Console.Write("Lütfen yeni tarihi aa.gg.yy biçiminde girin..:");
            arr[index] = DateTime.Parse(Console.ReadLine());
        }


    }
}
