using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWith_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor = new Instructor("John", "Programmer");
            instructor.Print();
            Console.ReadLine();
        }
    }
}
