﻿using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualBasic.CompilerServices;

namespace Exercuses_Working_with_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1- Write a program and ask the user to enter a few numbers separated by a hyphen.
             * Work out if the numbers are consecutive.
             * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
             * display a message: "Consecutive"; otherwise, display "Not Consecutive".
             */

            /*Console.WriteLine("Enter a few numbers separated by a hyphen. E.g: 5-6-7-8-9");

            var input = Console.ReadLine();

            // minor validations
            if (!input.Contains('-'))
            {
                Console.WriteLine("Enter a few numbers separated by a hyphen. E.g: 5-6-7-8-9");
                Console.WriteLine("Please try again, bye...");
                return;
            }

            // try split the input to string by hyphen '-'
            var splittedInputs = input.Split('-');
            
            // try to do conversion and handle exception
            try
            {
                // convert to a list of ints using LINQ
                var numbersList = splittedInputs.Select(int.Parse).ToList();
                // print sample output
                Console.WriteLine(string.Join(", ", numbersList));

                // check if number is consecutive or not
                var result = isConsecutive(numbersList);

                Console.WriteLine(result ? "Consecutive" : "Not Consecutive");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format found.. Try again... Bye..");
            }*/

            // EXERCISE 2:
            /**
             * 2- Write a program and ask the user to enter a few numbers separated by a hyphen.
             * If the user simply presses Enter, without supplying an input,
             * exit immediately; otherwise, check to see if there are duplicates.
             * If so, display "Duplicate" on the console.
             */

            /*Console.WriteLine("Enter a few numbers separated by a hyphen. E.g: 5-6-7-8-9");

            var input = Console.ReadLine();

            // minor validations
            if (!input.Contains('-'))
            {
                Console.WriteLine("Enter a few numbers separated by a hyphen. E.g: 5-6-7-8-9");
                Console.WriteLine("Please try again, bye...");
                return;
            }

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Enter a few numbers separated by a hyphen. E.g: 5-6-7-8-9");
                Console.WriteLine("Please try again, bye...");
                return;
            }

            // try split the input to string by hyphen '-'
            var splitInputs = input.Split('-');
            var singleString = string.Join("", splitInputs);
            var charList = new List<char>();

            // check for duplicates
            var result = isDuplicate(singleString, charList);

            Console.WriteLine(result ? "Duplicates" : "No duplicates found");
            */

            // EXERCISE 3:
            /**
             * 3- Write a program and ask the user to enter a time value
             * in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59.
             * If the time is valid, display "Ok"; otherwise, display "Invalid Time".
             * If the user doesn't provide any values, consider it as invalid time.
             */

            Console.WriteLine(@"Enter a valid time value (in 24-hour time format: 19:00, 12:00
Valid time format should be between: 00:00 and 23:59");

            // get user input
            var userInput = Console.ReadLine();

            // call void function to check time value inputted by user
            isValidTime(userInput);
        }

        public static bool isConsecutive(List<int> numberLists)
        {
            // handle edgecase

            if (numberLists.Count < 2)
                return false;

            // get difference
            var difference = numberLists[1] - numberLists[0];


            for (var i = 0; i < numberLists.Count - 1; i++) // removing the difference index
            {
                if (numberLists[i + 1] - numberLists[i] != difference)
                    return false;
            }
            return true;
        }

        public static bool isDuplicate(string sourceString, List<char> charList)
        {
            foreach (var character in sourceString)
            {
                if (!charList.Contains(character))
                    charList.Add(character);
                else
                    return true;
            }

            return false;
        }

        public static void isValidTime(string timeValue)
        {
            // try to convert timeValue to a valid date string else display invalid time
            try
            {
                var dateTime = DateTime.Parse(timeValue).TimeOfDay;
                Console.WriteLine("Time: " + dateTime);
                Console.WriteLine("OK");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Time");
            }
        }

    }
}
