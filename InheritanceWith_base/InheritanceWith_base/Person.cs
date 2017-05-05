using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWith_base
{
    class Person
    {
        public Person(string name)
        {
            m_strName = name;
        }

        public string GetName()
        {
            return m_strName;
        }

        private string m_strName;
    }
}
