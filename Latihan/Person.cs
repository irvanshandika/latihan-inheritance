﻿using System;

namespace Latihan
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0}, and Age : {1}", Name, Age);
        }
    }
}
