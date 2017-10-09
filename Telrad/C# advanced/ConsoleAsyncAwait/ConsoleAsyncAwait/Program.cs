using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAsyncAwait
{
    class Program
    {
        public static async Task<string> GetWebPage()
        {
            using (HttpClient client = new HttpClient())
            {
                string res = await client.GetStringAsync("http://www.google.com");
                return res;
            }
        }

        static void Main(string[] args)
        {
            string page = GetWebPage().Result;
            Console.WriteLine(page);
            Console.ReadKey();
        }
    }
}
