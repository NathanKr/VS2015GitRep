using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsole
{
    public class Instructor : Person
    {
        private float m_fSalary;

        public void DisplayInstructor()
        {
            Console.WriteLine("first name : {0} , last name : {1} , age : {2} , salary : {3}",
                FirstName, LastName, Age, m_fSalary);
        }

        public float Salary
        {
            get { return m_fSalary; }
            set { m_fSalary = value; }
        }
    }
}
