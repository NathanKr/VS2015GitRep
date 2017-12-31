using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_5_m
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,nFactorial, i;
            Console.WriteLine("please enter integer for factorial");
            num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                nFactorial = 1;
                for (i = 2; i <= num; i++)
                {
                    nFactorial *=  i;
                }

                Console.WriteLine("factorial using for : {0}", nFactorial);

                i = num;
                nFactorial = 1;
                while (i > 0)
                {
                    nFactorial *= i;
                    i--;
                }

                Console.WriteLine("factorial using while : {0}", nFactorial);
            }


            Console.Read();
        }
    }
}
