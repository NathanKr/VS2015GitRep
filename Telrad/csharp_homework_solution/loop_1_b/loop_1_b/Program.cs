using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 10,numbersLeft;
            numbersLeft = numbers;
            float sum = 0, avg;

            while(numbersLeft > 0)
            {
                Console.WriteLine("please enter a number and hit enter");
                float fNumber = float.Parse(Console.ReadLine());
                sum += fNumber;
                numbersLeft--;
            }
            avg = sum / numbers;

            Console.WriteLine("sum : {0} , average : {1}",sum,avg);

            Console.Read();
        }
    }
}
