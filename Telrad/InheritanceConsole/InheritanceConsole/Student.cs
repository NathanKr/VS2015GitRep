using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsole
{
    public class Student : Person
    {
        private float m_fGradeAvg;

        public void DisplayStudent()
        {
            Console.WriteLine("first name : {0} , last name : {1} , age : {2} , grade avarage : {3}",
                FirstName, LastName, Age, m_fGradeAvg);
        }

        public float GradeAverage
        {
            get { return m_fGradeAvg; }
            set { m_fGradeAvg = value; }
        }
    }
}
