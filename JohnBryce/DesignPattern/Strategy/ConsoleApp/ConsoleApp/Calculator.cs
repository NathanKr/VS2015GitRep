using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Calculator
    {
        public IOperation Operation { get; set; }

        public Calculator(IOperation oper)
        {
            Operation = oper;
        }

        public double Calculate(double arg1, double arg2)
        {
            return Operation.Calaculate(arg1, arg2);
        }
    }
}
