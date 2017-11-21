using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle.Draw is called");
        }
    }
}
