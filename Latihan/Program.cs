using System;

namespace Latihan
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Mike";
            person.Age = 20;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Thomas";
            teacher.Age = 30;
            teacher.TeacherID = "190203";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "Sara";
            student.Age = 19;
            student.StudentID = "10506";
            student.Email = "sara@amikom.ac.id";
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}