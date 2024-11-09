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
            /* var random = new Random();

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
             }*/

            // Exercise 5:
            /**
             * 5- Write a program and ask the user to enter a series of numbers separated by comma.
             * Find the maximum of the numbers and display it on the console.
             * For example, if the user enters “5, 3, 8, 1, 4",
             * the program should display 8.
             */

            // version 1
            /*// Ask user to enter numbers separated by comma
            Console.WriteLine("Enter numbers separated by commas");
            var inputs = Console.ReadLine();
            var numbersList = new List<int>();
            // loop through string characters and try convert values to string
            for (int i = 0; i < inputs.Length; i++)
            {
                // Skip commas or spaces
                if (inputs[i] == ',' || inputs[i] == ' ')
                    continue;

                // Check if the character is a digit (between '0' and '9')
                if (inputs[i] >= '0' && inputs[i] <= '9')
                {
                    // Convert the character to its decimal value by subtracting '0'
                    int number = inputs[i] - '0';
                    numbersList.Add(number);
                }
                else
                {
                    Console.WriteLine($"Invalid character '{inputs[i]}' found... skipping");
                }
            }
            // print the max value
            if (!(numbersList.Count == 0))
            {
                Console.WriteLine($"Max value in your list is: {numbersList.Max()}");
            }
            else Console.WriteLine("No valid input found");*/

            /*// version 2:
            // Ask the user to enter numbers separated by commas
            Console.WriteLine("Enter numbers separated by commas:");
            var inputs = Console.ReadLine();

            var numbersList = new List<int>();

            // Split the input string by commas
            var numbers = inputs.Split(',');

            foreach (var number in numbers)
            {
                // Trim any whitespace around each split number and try to parse it as an integer
                if (int.TryParse(number.Trim(), out int parsedNumber))
                {
                    numbersList.Add(parsedNumber);
                }
                else
                {
                    Console.WriteLine($"Invalid character '{number}' found... skipping");
                }
            }

            // Print the max value if there are any valid numbers
            if (numbersList.Count > 0)
            {
                Console.WriteLine($"Max value in your list is: {numbersList.Max()}");
            }
            else
            {
                Console.WriteLine("No valid numbers found.");
            }*/

            // Exercise 6:
            /**
             * Write a program which takes two numbers
             * from the console and displays the maximum of the two.
             */
            /* Console.WriteLine("Enter first number");
             try
             {
                 int firstNumber = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter second number");
                 int secondNumber = Convert.ToInt32(Console.ReadLine());
                 if (firstNumber > secondNumber)
                 {
                     Console.WriteLine($"Max number is: {firstNumber}");
                 }
                 else
                 {
                     Console.WriteLine($"Max number is: {secondNumber}");
                 }
             }
             catch (FormatException)
             {
                 Console.WriteLine("Invalid input... Bye...");
             }*/

            // Exercise 7:
            /**
             * Write a program and ask the user to enter the width and height of an image.
             * Then tell if the image is landscape or portrait.
             */
            /*Console.WriteLine("Enter width of image");
             try
             {
                 int imgWidth = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter height of image");
                 int imgHeight = Convert.ToInt32(Console.ReadLine());
                 if (imgHeight > imgWidth)
                 {
                     Console.WriteLine("Image is portrait");
                 }
                 else if (imgWidth > imgHeight)
                 {
                     Console.WriteLine("Image is landscape");
                 }
                 else
                {
                    Console.WriteLine("Image is a square, all sides are equal");
                }
             }
             catch (FormatException)
             {
                 Console.WriteLine("Invalid input... Bye...");
             }*/

            // Exercise 8:
            /**
             * Your job is to write a program for a speed camera.
             * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
             * Write a program that asks the user to enter the speed limit.
             * Once set, the program asks for the speed of a car.
             * If the user enters a value less than the speed limit, program should display Ok on the console.
             * If the value is above the speed limit, the program should calculate the number of demerit points.
             * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
             * If the number of demerit points is above 12, the program should display License Suspended.
             */

            try
            {
                Console.WriteLine("Enter speed limit");
                int speedLimit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter speed of a car");
                int carSpeed = Convert.ToInt32(Console.ReadLine());

                if (carSpeed <= speedLimit)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    // calculate difference in speed
                    int speedDifference = carSpeed - speedLimit;

                    // calculate demerit points (1 point per 5km/hr over the limit
                    int demeritPoints = speedDifference / 5;

                    // Display demerit points
                    Console.WriteLine($"Demerit Points: {demeritPoints}");

                    // Check if points exceed 12 for license suspension
                    if (demeritPoints > 12)
                    {
                        Console.WriteLine("License Suspended");
                    }
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


        }
}
}

