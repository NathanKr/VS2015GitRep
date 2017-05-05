using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // i am caller of Excel and i know i need to is Canon because it is connected to my PC
            CanonPrinter printer = new CanonPrinter();
            Excel excel = new Excel(printer);
            string someFile = "a.csv";
            excel.PrintFile(someFile);

            Console.ReadLine();
        }
    }
}
