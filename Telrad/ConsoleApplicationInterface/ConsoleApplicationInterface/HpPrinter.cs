using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInterface
{
    class HpPrinter : IPrinter
    {
        public void Print(string strFileFullPath)
        {
            Console.WriteLine("i can print this file i am HP");
        }

    }
}
