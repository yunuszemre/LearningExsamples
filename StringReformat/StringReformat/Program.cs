using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReformat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "emre";
            Console.WriteLine(StringFormat(ref s));
            Console.ReadKey();
        }
        private static string StringFormat(ref string s)
        {
            string value = null;
            char[] chars = new char[0];
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        counter++;
                        if (!chars.Contains(s[i]))
                        {
                            Array.Resize(ref chars, chars.Length + 1);
                            chars[chars.Length - 1] = s[i];
                        }
                       
                    }
                    else
                    {
                        counter = 0;
                    }
                    
                }
                
            }
            for (int k = 0; k < chars.Length; k++)
            {
                value += counter.ToString() + chars[k];
            }

            return value;
        }
    }
}
