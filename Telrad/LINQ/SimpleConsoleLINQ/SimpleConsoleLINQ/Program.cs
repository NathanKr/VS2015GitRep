using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "world", "this" ,"is" ,"LINQ" };
            //Get only short words
            IEnumerable<string>  shortWords = from word in words
                             where word.Length <= 4
                             select word;

            //Print each word out
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
