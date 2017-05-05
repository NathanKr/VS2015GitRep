using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPolymorphism
{
    interface IAnimal
    {
        String Type { get; set; } // 
        float Speed { get; set; } // קילומטר לשעה
        void Print();
    }
}
