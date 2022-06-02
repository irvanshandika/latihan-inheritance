using System;

namespace Latihan
{
    public class Teacher : Person
    {
        public string TeacherID { get; set; }
        public string Subject { get; set; }
        
        public void GetNameAndAge()
        {
            Console.WriteLine("The teacher has name : {0}, Age : {1}, Teacher ID : {2}, and Subject : {3}", Name, Age, TeacherID, Subject);
        }
    }
}
