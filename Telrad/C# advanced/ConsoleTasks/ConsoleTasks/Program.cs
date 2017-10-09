using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTasks
{
    class Program
    {

        static void Main(string[] args)
        {
            Task<int> task = Task.Run(()=> {
                DateTime dtStart = DateTime.Now , dtFinish;
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(i);
                }
                dtFinish = DateTime.Now;
                return (dtFinish-dtStart).Milliseconds;
            });

            task.Wait();
            Console.WriteLine("task duration [ms] : {0}",task.Result);
            Console.ReadKey();
        }
    }
}
