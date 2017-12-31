using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_simple_5b
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3,sum;
            float avg;
            Console.WriteLine("please enter integer and hit enter");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter integer and hit enter");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter integer integer and hit enter");
            num3 = int.Parse(Console.ReadLine());
            sum = num1 + num2 + num3;
            avg = (float)sum / 3;
            Console.WriteLine("sum : {0} , average : {1}",sum,avg);
            Console.Read();
        }
    }
}
