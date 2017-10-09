using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLambdaExpression
{
    class Program
    {
        delegate int BasicOperation(int num1, int num2);

        static void Main(string[] args)
        {
            BasicOperation mul = (int a, int b) => { return a * b; };
            BasicOperation add = (int a, int b) => { return a + b; };
            Console.WriteLine(add(1,2));
            Console.WriteLine(mul(3, 4));
            Console.ReadKey();
        }
    }
}
