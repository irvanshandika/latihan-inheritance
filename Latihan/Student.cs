using System;

namespace Latihan
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public string Email { get; set; }
        
        public void GetNameAndAge()
        {
            Console.WriteLine("The student has name : {0}, Age : {1}, Student ID : {2}, Email : {3}", Name, Age, StudentID, Email);
        }
    }
}

