using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSHA256
{
    class Program
    {
        static void Main(string[] args)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            SHA256 sha = SHA256.Create();
            string strText1 = "some text 1";
            byte[] arHashCodeSha256 = sha.ComputeHash(unicode.GetBytes(strText1));
            foreach (var item in arHashCodeSha256)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
