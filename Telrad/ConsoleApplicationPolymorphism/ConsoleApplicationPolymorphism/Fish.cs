using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPolymorphism
{
    class Fish : IAnimal
    {
        public Fish(string type, float speed,int zimim)
        {
            Type = type;
            Speed = speed;
            Zimim = zimim;
        }

        public string Type { get; set; }
        public float Speed { get; set; }
        public int Zimim { get; set; } // מספר זימים

        public void Print()
        {
            Console.WriteLine("i am fish.  type : {0} , speed {1} , zimim {2}",
                Type, Speed, Zimim);
        }
    }
}
