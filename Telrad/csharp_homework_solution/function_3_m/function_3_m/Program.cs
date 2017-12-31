using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_3_m
{
    class Program
    {
        static float Sum(float fnum1, float fnum2)
        {
            return fnum1 + fnum2;
        }
        static void Main(string[] args)
        {
            float fNum1=2.3F, fNum2=3.4F, fSum;
            fSum = Sum(fNum1, fNum2);
            Console.WriteLine("sum is : {0}",fSum);
            Console.Read();
        }
    }
}
