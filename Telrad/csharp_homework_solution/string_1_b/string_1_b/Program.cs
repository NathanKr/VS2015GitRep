using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_1_b
{
    class Program
    {
        /// <summary>
        /// true if str1 is inside str2
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        static bool DoesContain(string str1 , string str2)
        {
            return str2.Contains(str1);
        }


        static void Main(string[] args)
        {
            // true because ell is inside (sub string) hello
            Console.WriteLine(DoesContain("ell","hello"));

            // false because ho is not inside hello
            Console.WriteLine(DoesContain("ho", "hello"));

            Console.Read();
        }
    }
}
