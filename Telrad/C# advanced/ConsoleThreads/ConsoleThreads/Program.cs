using System.Threading;
using System;

namespace ConsoleThreads
{
    class Program
    {
        private static void ThreadFunc()
        {
            write("worker thread");
        }


        private static void write(string strMsg)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i : {0} , {2} Thread id : {1}", i,
                    Thread.CurrentThread.ManagedThreadId, strMsg);
                Thread.Sleep(1);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadFunc));
            t.Start();
            write("main thread");
            t.Join();
            Console.ReadKey();
        }
    }
}
