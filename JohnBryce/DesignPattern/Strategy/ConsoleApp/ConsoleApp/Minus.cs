using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Minus : IOperation
    {
        public double Calaculate(double arg1, double arg2)
        {
            return (arg1 - arg2);
        }
    }
}
