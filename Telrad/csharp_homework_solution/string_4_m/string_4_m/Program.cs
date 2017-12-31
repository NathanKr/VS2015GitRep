using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_4_m
{
    class Program
    {
        static char[] GetCharArrayFromString(string str1)
        {
            char[] arChars = new char[str1.Length];

            for (int i = 0; i < arChars.Length; i++)
            {
                arChars[i] = str1[i];
            }

            return arChars;
        }

        static void Main(string[] args)
        {
            char[] arChars = GetCharArrayFromString("hello world");

            // --- print the array
            for (int i = 0; i < arChars.Length; i++)
            {
                Console.WriteLine(arChars[i]);
            }

            Console.Read();
        }
    }
}
