using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            IShape iShape = factory.GetShape("Circle");
            if(iShape != null)
            {
                iShape.Draw();
            }

            iShape = factory.GetShape("Rectangle");
            if (iShape != null)
            {
                iShape.Draw();
            }

            Console.Read();
        }
    }
}
