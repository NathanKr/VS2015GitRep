using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_math_2_m
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,tmp;
            Console.WriteLine("please enter integer and hit enter");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter integer and hit enter");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("before switch , num1 : {0} , num2 {1}", num1, num2);
            tmp = num1;
            num1 = num2;
            num2 = tmp;

            Console.WriteLine("after switch , num1 : {0} , num2 {1}", num1, num2);

            Console.Read();
        }
    }
}
