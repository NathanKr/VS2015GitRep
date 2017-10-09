using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 36;
            object obj1 = a;    
            int b = (int)obj1;  

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(true);
            arrayList.Add("hello");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
