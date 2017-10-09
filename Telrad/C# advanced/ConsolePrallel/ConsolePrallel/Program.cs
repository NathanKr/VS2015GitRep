using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsolePrallel
{
    class Program
    {

        static void Main(string[] args)
        {
            Parallel.For(0, 200, i =>
            {
                write(i);
            });

            waitForKey();

            var ar = Enumerable.Range(0, 10);
            Parallel.ForEach(ar,i => {
                write(i);
            });

            waitForKey();
        }

        private static void waitForKey()
        {
            Console.WriteLine("hit a key"); Console.ReadKey();
        }

        private static void write(int i)
        {
            Console.WriteLine("task id : {0} , i : {1}", Task.CurrentId, i);
        }

    }
}
