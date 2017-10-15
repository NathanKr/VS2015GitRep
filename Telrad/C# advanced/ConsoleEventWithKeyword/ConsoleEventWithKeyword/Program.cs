using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventWithKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Publish pub = new Publish();
            pub.OnChanged += () => { Console.WriteLine("handle 1 event"); };
            pub.OnChanged += () => { Console.WriteLine("handle 2 event"); };

            pub.RaiseEvent();

            Console.ReadKey();
        }
    }
}
