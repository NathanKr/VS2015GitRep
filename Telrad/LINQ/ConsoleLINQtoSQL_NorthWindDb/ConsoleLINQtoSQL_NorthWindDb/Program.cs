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
            
            // inset employee
            insertBarakObama(nw);


            // Update employee
            if (updateEmployeeCityByName(nw, "Barak", "John Hopkins 12") != null)
            {
                Console.WriteLine("update failed");
            }

            // delete employee
            Console.WriteLine(string.Format("employees deleted : {0}", deleteEmployeesByFirstName(nw, "Barak")));

            selectWithQuery(nw);

            SelectWithLambda(nw);

            Console.ReadLine();
        }

        private static int deleteEmployeesByFirstName(DataClasses1DataContext nw, string strFirstName)
        {
            var listToBeDeleted = nw.Employees.Where(emp => emp.FirstName == strFirstName);
            foreach (var emp in listToBeDeleted)
            {
                nw.Employees.DeleteOnSubmit(emp);
            }
            nw.SubmitChanges();
            return listToBeDeleted.Count();
        }

        private static Employee updateEmployeeCityByName(DataClasses1DataContext nw ,
            string strEmployeeFirstName, string strEmployeeAddress)
        {
            Employee employee = null;
            employee = nw.Employees.FirstOrDefault(emp => emp.FirstName == strEmployeeFirstName);

            if (employee != null)
            {
                employee.Address = strEmployeeAddress;
                nw.SubmitChanges();
            }

            return employee;
        }

        private static void insertBarakObama(DataClasses1DataContext nw)
        {
            Employee newEmployee = new Employee();
            newEmployee.City = "Washington";
            newEmployee.Address = "White house";
            newEmployee.BirthDate = new DateTime(1961, 8, 4);
            newEmployee.FirstName = "Barak";
            newEmployee.LastName = "Obama";

            nw.Employees.InsertOnSubmit(newEmployee);
            nw.SubmitChanges();
        }

        private static void selectWithQuery(DataClasses1DataContext nw)
        {
            var resultQuery = from cust in nw.Customers
                where cust.City == "Paris"
                select cust.CompanyName;

            foreach (var item in resultQuery)
            {
                Console.WriteLine(item);
            }
        }

        private static void SelectWithLambda(DataClasses1DataContext nw)
        {
            var resultLambda = nw.Customers.Where(x => x.City == "Paris").Select(x => x.CompanyName);


            foreach (var item in resultLambda)
            {
                Console.WriteLine(item);
            }
        }
    }
}
