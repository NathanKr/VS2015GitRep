using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntroduction
{
    class Program
    {
        
        static void Main(string[] args)
        {
            float fMax = 0,a=1;

            while(a > 0)
            {
                Console.Write("Please enter a number (0 or negative to quit) and click enter \n");
                string strLine = Console.ReadLine();
                if (float.TryParse(strLine, out a))
                {
                    if (a > 0)
                    {
                        if (a > fMax)
                        {
                            fMax = a;
                        }
                    }
                    else
                    {
                        if (fMax > 0)
                        {
                            Console.Write("max is : {0}", fMax);
                        }
                        else
                        {
                            Console.Write("exit without computation");
                        }
                        Console.Read();// wait for key
                    }
                }
                else
                {
                    Console.Write("error ! please insert only number\n");
                }
            } 
        }
    }
}
