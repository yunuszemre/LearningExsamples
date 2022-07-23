using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTrim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string s = "   Em  re  kljsdlkjf  ";
            Console.WriteLine(FullTrim(ref s));
            //char[] chars = s.ToCharArray();
            
            Console.ReadLine();
        }
        private static string FullTrim(ref string s)
        {
            string cıktı = "";
            string bos = " ";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].GetHashCode() == bos[0].GetHashCode())
                {

                }
                else
                {
                    cıktı += s[i];
                }
            }
            return cıktı;
        }
    }
}
