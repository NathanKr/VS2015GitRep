using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_simple_6b
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height,area;
            Console.WriteLine("please enter rectangle width [cm] and  hit enter");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter rectangle height [cm] and  hit enter");
            height = int.Parse(Console.ReadLine());
            area = width * height;
            Console.WriteLine("rectangle area : {0} [cm^2]",area);

            Console.Read();
        }
    }
}
