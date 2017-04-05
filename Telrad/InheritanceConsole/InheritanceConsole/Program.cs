using InheritanceConsole;
using System;

namespace InheritanceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- person
            Person person = new Person();
            person.Age = 11;
            person.FirstName = "Yossi";
            person.LastName = "Cohen";
            person.DisplayPerson();

            // --- instructor
            Instructor instructor = new Instructor();
            instructor.Salary = 7000;
            instructor.FirstName = "Avi";
            instructor.LastName = "Levi";
            instructor.DisplayPerson();
            instructor.DisplayInstructor();

            // --- student
            // --- instructor
            Student student= new Student();
            student.GradeAverage = 85;
            student.FirstName = "Noam";
            student.LastName = "Katz";
            student.DisplayPerson();
            student.DisplayStudent();



            Console.ReadLine();

        }
    }
}
