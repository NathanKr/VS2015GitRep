using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPolymorphism
{
    class Cat : IAnimal
    {
        public Cat(string name, float speed)
        {
            Type = name;
            Speed = speed;
        }

        public string Type { get; set; }
        public float Speed { get; set; }

        public void Print()
        {
            Console.WriteLine("i am cat , i do not give more info");
        }
    }
}
