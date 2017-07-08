using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleLinkLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "world", "this", "is", "LINQ" };
            //Get only short words using Lambda expression
            IEnumerable<string> shortWords =  words.Where(w => w.Length <= 4);

            //Print each word out
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
