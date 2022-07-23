using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tanımlamalar
            //string sayi = "1";

            //string ondalikliSayi = "2.8";
            ///*
            // * OverflowException ---> Değer aralığı için çok büyük bir değer geldi
            // * FormatException   ---> Girilen format istenilen biçimde değil
            // */
            //int int_sayi = Convert.ToInt32(sayi);
            ////Short => Convert.ToInt16()
            //short short_Sayi = Convert.ToInt16(sayi);
            ////Long = Convert.ToInt64()
            //long long_Sayi = Convert.ToInt64(sayi);

            //double double_Sayi = Convert.ToDouble(ondalikliSayi);

            //float float_Sayi = Convert.ToSingle(ondalikliSayi);

            //decimal decimal_Sayi = Convert.ToDecimal(ondalikliSayi);

            ////Parse Methodları
            ////Dönüştürülmek istenen tip üstünden primitive  typlarda kullanılabilir
            //int.Parse(sayi);
            //double.Parse(ondalikliSayi);
            //float.Parse(sayi);
            //decimal.Parse(ondalikliSayi);
            //long.Parse(sayi);
            //short.Parse(sayi);           


            ////bool bool_Sayi = Convert.ToBoolean(sayi);  
            #endregion

            #region Cevirmeler
            //byte byteSayi = 255;
            //int sayi1 = 1000;
            //int sayi = Convert.ToInt32(byteSayi);

            ////---------Cast Etme (Ricada Bulunma) Bir Tipi Diğer Tipe Dönüştürmeyi Dener Misin?------------------
            //long longSayi2 = (long)byteSayi;
            //byte byteSayi3 = (byte)sayi1;

            //Console.WriteLine(byteSayi3); // Kutu doldu boşattı, doldu boşalttı en son kalanı verdi

            //byte deger1 = 1;
            //byte deger2 = 0;
            //sbyte deger3 = -1;

            //bool sonuc1 = Convert.ToBoolean(deger1);
            //bool sonuc2 = Convert.ToBoolean(deger2);
            //bool sonuc3 = Convert.ToBoolean(deger3);

            //Console.WriteLine(sonuc1);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3); 
            #endregion

            #region Object tipi bütün tiplerin atasıdır
            //Bütün tiplerin atası object dir
            object sayi4 = new object();
            sayi4 = 4;
            object sayi5 = new object();
            sayi5 = 5;

            //Bütün tipler string tipine dönüştürülebilir
            string stringSayi = sayi4.ToString();
            #endregion

            #region Implicit Conversion && Explicit Conversion
            ////implicit Convert||Kapalı tip dönüşümü
            //int x = 150;
            //long y = x;
            //byte z = (byte)x;



            ////Explicit||Açık tip dönüşümü

            //long t = 1000;
            //int r = (int)t; 
            #endregion

            #region Boxing && Unboxing
            ////Boxing
            //int sayi = 150;
            //object object_sayi = new object();
            //object_sayi = sayi;

            ////Unboxing
            //int sayi2 = (int)object_sayi;
            ////ınvalid cast exception ==> boxing ypaılan tipten farklı bir türde çağırma yapılırsa bu hata fırlatılır
            //short sayi3 = (short)object_sayi;
            //// Boxing ve unboxing işlemi normal tip dönüşümüne göre 4 kat daha fazla zaman aldığı için bu işlemlerden mümkün olduğunca kaçınılmalıdır
            #endregion

            string sayi = "123";
            //---------Int----------------
            int intSayi = int.Parse(sayi);
            int intSayi2 = Convert.ToInt32(sayi);
            //---------Long----------------
            long longSayi = long.Parse(sayi);
            long longSayi2 = Convert.ToInt64(sayi);
            long longSayi3 = (long)intSayi;
            //---------Uint----------------
            uint uintSayi = uint.Parse(sayi);
            uint uintSayi2 = Convert.ToUInt32(sayi);
            uint uintSayi3 = (uint)intSayi;
            //--------Ulong----------------
            ulong ulongSayi = ulong.Parse(sayi);
            ulong ulongSayi2 = Convert.ToUInt64(sayi);
            ulong ulongSayi3 = (ulong)intSayi;
            //--------Short----------------
            short shortSayi = short.Parse(sayi);
            short shortSayi3 = Convert.ToInt16(sayi);
            short shortSayi2 = (short)intSayi;
            //--------Ushort---------------
            ushort ushortSayi = ushort.Parse(sayi);
            ushort ushortSayi2 = Convert.ToUInt16(sayi);
            ushort usUshortSayi3 = (ushort)intSayi;
            //--------Byte-----------------
            byte byteSayi = byte.Parse(sayi);
            byte byteSayi2 = Convert.ToByte(sayi);
            byte byteSayi3 = (byte)intSayi;
            //--------Sbyte----------------
            sbyte sbyteSayi = sbyte.Parse(sayi);
            sbyte sbyteSayi2 = (sbyte)intSayi;
            sbyte sbyteSayi3 = Convert.ToSByte(sayi);
            //--------Decimal--------------
            decimal decSayi = decimal.Parse(sayi);
            decimal decimalSayi = Convert.ToDecimal(sayi);
            decimal decimalSayi3 = (decimal)intSayi;
            //------Float-Single-----------
            float floatSayi = float.Parse(sayi);
            float floatSayi2 = Convert.ToSingle(sayi);
            float floatSayi3 = (float)intSayi;
            //--------Double----------------
            double doubleSayi = double.Parse(sayi);
            double doubleSayi2 = Convert.ToDouble(sayi);
            double doubleSayi3 = (double)intSayi;
            //--------Char------------------
            char charSayi = (char)intSayi;
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            string s = null;
            int s2= Convert.ToInt32(s);
            Console.WriteLine(s2);
            int s1 = int.Parse(s);
            Console.Write(s1);


            Console.WriteLine(charSayi);

            Console.ReadLine();
        }
    }
}
