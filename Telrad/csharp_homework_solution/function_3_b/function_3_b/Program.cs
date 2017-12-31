using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_3_b
{
    class Program
    {
        static float Min(float fNum1 , float fNum2, float fNum3)
        {
            float fMin;

            fMin = fNum1 < fNum2 ? fNum1 : fNum2;
            
            if(fNum3 < fMin)
            {
                fMin = fNum3;
            }

            return fMin;
        }

        static void Main(string[] args)
        {
            // --- check all position for max in arguments
            Console.WriteLine(Min(1,2.2F,3));
            Console.WriteLine(Min(1, 3, 2.2F));
            Console.WriteLine(Min(3, 2.2F , 1));

            Console.Read();
        }
    }
}
