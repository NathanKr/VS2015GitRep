using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntroduction
{
    class Program
    {
        /*
                                                דרוש  
        רשום תרשים זרימה שמתאר את הבעיה הבאה :
        קלוט מספרים עד שתקלוט מספר שלילי או אפס.
        הצג את הערך הגבוה ביותר שנקלט.
        הערה : יתכן שהמספר הראשון הוא שלילי
        הרץ עבור המקרים הבאים
        - -1
        - 1 2 12 7 0
        - 4 6 7 -1
        - 3 hello 4 1 0
         */
        static void Main(string[] args)
        {
            float fMax = 0,a=1;

            while(a > 0)
            {
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
                    a = 1;//so it will continue
                }
            } 
        }
    }
}
