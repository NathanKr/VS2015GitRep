using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle.Draw is called");
        }
    }
}
