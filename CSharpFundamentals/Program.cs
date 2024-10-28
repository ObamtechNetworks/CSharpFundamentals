﻿using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* var john = new Person();
             john.FirstName = "John";
             john.LastName = "Smith";
             john.Introduce();

             Calculator calculator = new Calculator();
             var result = calculator.Add(1, 2);
             Console.WriteLine(result);

             Console.WriteLine("================ARRAYS==============");
             var numbers = new int[3];
             numbers[0] = 1;
             Console.WriteLine(numbers[0]);
             Console.WriteLine(numbers[1]);
             Console.WriteLine(numbers[2]);

             var flags = new bool[3];
             flags[0] = true;

             Console.WriteLine(flags[0]);
             Console.WriteLine(flags[1]);
             Console.WriteLine(flags[2]); // uinitialized parts of arrays are set to 0 or false

             var names = new string[3] { "Jack", "John", "Mary" };
             Console.WriteLine(names[0]);
             Console.WriteLine(names[1]);
             Console.WriteLine(names[2]);

             Console.WriteLine("stringBackslash\\");

             // Verbatim strings
             string path = "c:\\projects\\project1\\folder";
             // using verbatim
             string verbatimPath = @"c:\projects\project1\folder";
             Console.WriteLine(string.Format("Path1 -> {0} \nPath2 -> {1}", path, verbatimPath));*/

            var firstName = "Michael";
            var lastName = "Bamidele";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is  {0} {1}", firstName, lastName);

            Console.WriteLine("String.join method");
            var names = new string[] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);

            var text = @"Hi  John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder3";
            Console.WriteLine(text);
        }
    }
}
