using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            Console.WriteLine("please enter integer and hit enter");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter integer and hit enter");
            second = int.Parse(Console.ReadLine());
            if(first > second)
            {
                Console.WriteLine("max value is : {0}",first);
            }
            else if (second > first )
            {
                Console.WriteLine("max value is : {0}", second);
            }
            else
            {
                Console.WriteLine("values are equal");
            }

            Console.Read();
        }
    }
}
