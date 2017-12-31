using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_4_m
{
    class Program
    {
        static void ComputeAvgAndSum(float fNum1,float fNum2,out float fSum , out float fAvg)
        {
            fSum = fNum1 + fNum2;
            fAvg = fSum / 2;
        }

        static void Main(string[] args)
        {
            float fSum, fAvg;
            ComputeAvgAndSum(3.2F, 4.6F, out fSum, out fAvg);
            Console.WriteLine("sum : {0} , average : {1}",fSum,fAvg);

            Console.Read();
        }
    }
}
