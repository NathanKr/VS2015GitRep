using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1_b
{
    class Program
    {
        static bool CopyFirstToSecond(float [] arFirst , float[] arSecond)
        {
            bool bRes = arFirst.Length == arSecond.Length;

            if(bRes)
            {
                for (int i = 0; i < arFirst.Length; i++)
                {
                    arSecond[i] = arFirst[i];
                }

            }

            return bRes;
        }

        static void Show(float[] arNUmbers)
        {
            for (int i = 0; i < arNUmbers.Length; i++)
            {
                Console.WriteLine(arNUmbers[i]);
            }
        }

        static void Main(string[] args)
        {
            // --- prepare arrays
            float[] ar1, ar2;
            int nLen = 5;
            ar1 = new float[nLen];
            ar2 = new float[nLen];
            // --- fill array with numbers
            ar1[0] = 3; ar1[1] = 4.5F; ar1[2] = 1.7F; ar1[3] = 14.2F; ar1[4] = 5.8F;

            // --- show ar2 BEFORE copy into it
            Show(ar2);

            // --- copy
            CopyFirstToSecond(ar1, ar2);

            // --- show ar2 AFTER copy into it
            Show(ar2);


            Console.Read();
        }
    }
}
