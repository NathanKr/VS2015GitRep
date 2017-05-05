using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals = new IAnimal[5];
            Cat cat1, cat2,cat3;
            Fish fish1, fish2;
            cat1 = new Cat("Lion",40);
            cat2 = new Cat("Chita", 100);
            cat3 = new Cat("Puma", 80);
            fish1 = new Fish("Lokus",2,10);
            fish2 = new Fish("Barbunia", 4, 20);
            animals[0] = cat1;
            animals[4] = cat2;
            animals[2] = cat3;
            animals[3] = fish1;
            animals[1] = fish2;


            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Print();
            }
            Console.ReadLine();
        }
    }
}
