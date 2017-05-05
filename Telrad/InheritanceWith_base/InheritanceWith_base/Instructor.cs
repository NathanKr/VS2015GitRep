using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWith_base
{
    class Instructor : Person
    {
        // we MUST use base to initialize m_strName of Person because it is private
        public Instructor(string name, string strOccupation) : base(name)
        {
            m_strOccupation = strOccupation;
        }

        public void Print()
        {
            Console.WriteLine("name : {0} , Occupation : {1}", GetName(), m_strOccupation);
        }

        private string m_strOccupation;
    }
}
