using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        /* adding operation without using strategy design pattern will change Calculator code thus 
         * violate open/closed principle */

        static void Main(string[] args)
        {
            Calculator calc = new Calculator(new Plus());
            // -- use first strategy
            Console.WriteLine("Add : {0}" , calc.Calculate(1,2));

            // -- use second strategy
            calc.Operation = new Minus();
            Console.WriteLine("Sub : {0}", calc.Calculate(3, 2));

            Console.Read();
        }
    }
}
