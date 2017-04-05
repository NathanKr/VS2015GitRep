using System;

namespace InheritanceConsole
{
    public class Person
    {
        private string m_strFirstName;
        private string m_strLastName;
        private int m_nAge;

       

        public void DisplayPerson()
        {
           Console.WriteLine("first name : {0} , last name : {1} , age : {2}",
               m_strFirstName,m_strLastName,m_nAge);
        }

        public int Age
        {
            get { return m_nAge; }
            set { m_nAge = value; }
        }

        public string FirstName
        {
            get { return m_strFirstName; }
            set { m_strFirstName = value; }
        }

        public string LastName
        {
            get { return m_strLastName; }
            set { m_strLastName = value; }   
        }
    }
}
