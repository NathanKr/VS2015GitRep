using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers1 = new int[] {3,5,7,9,11};
            int[] Numbers = new int[5];
            int nSum=0;
            Numbers[0] = 3;
            Numbers[1] = 5;
            Numbers[2] = 7;
            Numbers[3] = 9;
            Numbers[4] = 11;

            Console.Write("Numbers[2] : {0}\n", Numbers[2]);
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Numbers[{0}] : {1}\n" , i , Numbers[i]);
            }

            foreach (int number in Numbers)
            {
                nSum += number;
            }

            Console.Write("Sum : {0}\n", nSum);

            Console.ReadLine();
        }
    }
}
