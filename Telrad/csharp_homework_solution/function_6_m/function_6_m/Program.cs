using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_6_m
{
    class Program
    {
        static void Swap(ref float fNum1 , ref float fNum2)
        {
            float fTmp;
            fTmp = fNum1;
            fNum1 = fNum2;
            fNum2 = fTmp;
        }

        static void Main(string[] args)
        {
            float fnum1=4.3F, fnum2=5.5F;
            Console.WriteLine("before swap . fnum1 : {0} , fnum2 : {1}",fnum1,fnum2);
            Swap(ref fnum1 , ref fnum2);
            Console.WriteLine("after swap . fnum1 : {0} , fnum2 : {1}", fnum1, fnum2);
            Console.Read();
        }
    }
}
