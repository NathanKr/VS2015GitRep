using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAsIs
{
    class Program
    {
        class Base {};

        class Derived : Base {};

        static bool IsDerivedVer1(Base b){
            return b is Derived;
        }

        static bool IsDerivedVer2(Base b){
            Derived d = b as Derived;
            return d != null;
        }

        static void Main(string[] args)
        {
            Base b = new Base();
            Derived d = new Derived();

            Console.WriteLine("is derived : {0}", IsDerivedVer1(b));
            Console.WriteLine("is derived : {0}", IsDerivedVer1(d));

            Console.WriteLine("is derived : {0}", IsDerivedVer2(b));
            Console.WriteLine("is derived : {0}", IsDerivedVer2(d));


            Console.ReadKey();
        }
    }
}
