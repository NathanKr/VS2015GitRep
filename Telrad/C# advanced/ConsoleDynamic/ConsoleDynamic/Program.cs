using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a;
            a = 1;
            a++;
            Console.WriteLine(a);
            a = "hello";
            a += " world";
            Console.WriteLine(a);
            Console.ReadKey();
        }

    }
}
