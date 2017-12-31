using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_2_m
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arNumbers = { 1.1F, 5.4F, 5.2F, 9.3F };
            float fSum=0, fAvg;

            for (int i = 0; i < arNumbers.Length; i++)
            {
                fSum += arNumbers[i];
            }

            fAvg = fSum / arNumbers.Length;

            Console.WriteLine("sum : {0} , average : {1}", fSum, fAvg);

            Console.Read();
        }
    }
}
