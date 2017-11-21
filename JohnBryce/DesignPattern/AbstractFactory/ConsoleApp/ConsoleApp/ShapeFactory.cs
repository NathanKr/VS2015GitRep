using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ShapeFactory
    {
        public IShape GetShape(string strShape)
        {
            IShape iShape;

            switch (strShape)
            {
                case "Circle":
                    iShape = new Circle();
                    break;

                case "Rectangle":
                    iShape = new Rectangle();
                    break;

                case "Square":
                    iShape = new Square();
                    break;


                default:
                    iShape = null;
                    break;
            }

            return iShape;
        }
    }
}
