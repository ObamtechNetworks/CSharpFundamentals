using System.Threading.Channels;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exercise 1:
            /*
             * 
             * Write a program to count how many numbers between 1 and 100
             * are divisible by 3 with no remainder.
             * 
             * Display the count on the console.
             */

            /*var count = 0; // set counter to 0 as starting point
            for (var i = 1; i <= 100; i++)
            {
                // for each number from 1 to 100
                // check which number is divisible by 3
                if (i % 3 == 0)
                    count++; // if any, increase the counter
            }
            // display the count on the console
            Console.WriteLine(count);*/

            // exercise 2:
            /**
             * 2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
             * Calculate the sum of all the previously entered numbers
             * and display it on the console.
             */
            /*var sum = 0;

            Console.WriteLine("Enter as many numbers as you want, 'ok' to exit");
            while (true)
            {
                var userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    try
                    {
                        var newInput = Convert.ToInt16(userInput);
                        sum += newInput;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(string.Format("\nThanks for your time\nTotal: {0}", sum));
                        break;
                    }
                }
                else if (userInput == "ok")
                {
                    Console.WriteLine(string.Format("Thanks for your time\nTotal: {0}", sum));
                    break;
                }
                Console.WriteLine("Next number:         'ok' to exit");
            }*/

            // Exercise 3
            /**
             * Write a program and ask the user to enter a number.
             * Compute the factorial of the number and print it on the console.
             * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1
             * and display it as 5! = 120.
             */
            /* Console.WriteLine("Please enter a number");
             var number = Console.ReadLine();
             try
             {
                 var convertedNum = Convert.ToInt32(number);
                 var factorialResult = 1; // even if 0 is entered, loop will be false and value will be 0
                 for (int i = convertedNum; i >= 1; --i)
                 {
                     factorialResult *= i;
                 }
                 Console.WriteLine(string.Format("{0}! = {1}", convertedNum, factorialResult));
             }
             catch (Exception)
             {
                 Console.WriteLine("Invalid input");
             }*/

            //Exercise 4
            /**
             * Write a program that picks a random number between 1 and 10.
             * Give the user 4 chances to guess the number.
             * If the user guesses the number, display “You won";
             * otherwise, display “You lost".
             * (To make sure the program is behaving correctly,
             * you can display the secret number on the console first.)
             */

            // instantiate random class
            var random = new Random();

            // Generates a random number between 1 and 10
            var randomNumber = random.Next(1, 11);

            // list to store user guesses
            var guesses = new List<int>();

            Console.WriteLine("Guess the random number, between 1 and 10. You have four guesses.\nGood luck!");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter your guess: ");
                try
                {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    guesses.Add(guess);

                    // Check if the guess is correct
                    if (guess == randomNumber)
                    {
                        Console.WriteLine($"You won! The secret number is {randomNumber}");
                        break;  // Exit the loop if the user wins
                    }
                    else if (i < 3) // Give feedback only if it’s not the last attempt
                    {
                        Console.WriteLine("Incorrect! Try again...");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid number. Please enter a number between 1 and 10.");
                    i--;  // Don’t count this as an attempt if input was invalid
                }
            }

            // If the user didn't guess correctly after 4 attempts
            if (!guesses.Contains(randomNumber))
            {
                Console.WriteLine($"You lost! The secret number was: {randomNumber}");
            }




        }
}
}

