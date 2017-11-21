using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.GetInstance().Write("some error", Logger.Level.Error);
            Logger.GetInstance().Write("some warning", Logger.Level.Warning);

            Console.Read();
        }
    }
}
