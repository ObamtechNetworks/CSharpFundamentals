using System.Globalization;
using System.Runtime.InteropServices;
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

            Console.WriteLine("Enter a few numbers separated by a hyphen. E.g: 5-6-7-8-9");

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
            var splittedInputs = input.Split('-');
            var singleString = string.Join("", splittedInputs);
            var charList = new List<char>();

            // check for duplicates
            try
            {
                foreach (var character in singleString)
                {
                    if (!charList.Contains(character))
                        charList.Add(character);
                    else
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }

                Console.WriteLine("No duplicate found");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format found.. Try again... Bye..");
            }
        }

        /*public static bool isConsecutive(List<int> numberLists)
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
        }*/

    }
}
