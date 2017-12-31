using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_4._1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSize = 10;
            for (int nRow = 1; nRow <= nSize; nRow++)
            {
                for (int nCol = 1; nCol <= nSize; nCol++)
                {
                    Console.Write("{0} ", nRow*nCol);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
