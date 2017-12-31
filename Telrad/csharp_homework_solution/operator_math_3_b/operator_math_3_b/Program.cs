using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_math_3_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int mul, sub, add;
            float div;
            Console.WriteLine("please enter integer and hit enter");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter integer and hit enter");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter integer integer and hit enter");
            mul = num1 * num2;
            sub = num1 - num2;
            add = num1 + num2;
            div = (float)num1 / num2;

            Console.WriteLine("mul : {0} , sub: {1} , add {2} , div {3}", 
                mul,sub,add,div);

            Console.Read();
        }
    }
}
