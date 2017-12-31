using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_5_m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter character and hit enter");
            char c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case 'r':
                    Console.WriteLine("red");
                    break;

                case 'b':
                    Console.WriteLine("blue");
                    break;


                default:
                    Console.WriteLine("not defined");
                    break;
            }

            Console.Read();
        }
    }
}
