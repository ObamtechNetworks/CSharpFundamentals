﻿namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
