using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    class Program
    {
         delegate int BasicOperation(int num1, int num2);

        static int Add(int a, int b){
            return a + b;
        }

        static int Mul(int a, int b)
        {
            return a * b;
        }

        static void DoOperationAndPrint(int a, int b, BasicOperation operation)
        {
            Console.WriteLine("result : {0}",operation(a, b));
        }

        static void Main(string[] args)
        {
            int num1 = 2, num2 = 3;
            BasicOperation add = Add, mul = Mul;
            DoOperationAndPrint(num1, num2, mul);
            DoOperationAndPrint(num1, num2, add);
            Console.ReadKey();
        }
    }
}
