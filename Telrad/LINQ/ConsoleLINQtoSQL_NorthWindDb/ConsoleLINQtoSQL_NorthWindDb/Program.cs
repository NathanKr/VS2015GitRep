using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLINQtoSQL_NorthWindDb
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DataClasses1DataContext nw = new DataClasses1DataContext(strConnectionString);

            var resultQuery = from cust in nw.Customers
                where cust.City == "Paris"
                select cust.CompanyName;

            foreach (var item in resultQuery)
            {
                Console.WriteLine(item);
            }

            var resultLambda = nw.Customers.Where(x => x.City == "Paris").Select(x => x.CompanyName);
                              

            foreach (var item in resultLambda)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
