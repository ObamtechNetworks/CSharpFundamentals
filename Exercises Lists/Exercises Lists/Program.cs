﻿namespace Exercises_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Exercise ONE:
             * 
             * 1- When you post a message on Facebook, depending on the number of people who like your post,
             * Facebook displays different information.
            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            Depending on the number of names provided, display a message based on the above pattern.
             */
            /*var friendsList = new List<string>();
            Console.WriteLine("Enter different names of your friends");
            while (true)
            {
                try
                {
                    var inputs = Console.ReadLine(); // keep collecting user inputs unless empty values
                    if (!string.IsNullOrEmpty(inputs))
                    {
                        // Split on both commas and spaces, and remove any empty entries
                        // to handle inputs like: [ Segun, Bola, Amaka or Segun,Bola,Amaka or Segun Bola Amaka ]
                        friendsList.AddRange(inputs.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries));
                        *//*friendsList.Add(inputs);*//*
                    }
                    else // if empty value is supplied
                    {
                        if (friendsList.Count > 0)
                        {
                            if (friendsList.Count == 1)
                            {
                                Console.WriteLine($"[{friendsList[0]}] liked your post");
                                break;
                            }
                            if (friendsList.Count == 2)
                            {
                                Console.WriteLine($"[{friendsList[0]}] and [{friendsList[1]}] liked your post");
                                break;
                            }

                            if (friendsList.Count > 2)
                            {
                                Console.WriteLine($"[{friendsList[0]}], [{friendsList[1]}] and [{friendsList.Count - 2} other] liked your post");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No one liked your post");
                            break;
                        }
                    }
                }
                catch (Exception ext)
                {

                    Console.WriteLine($"An error occurred: {ext}");
                    break;
                }
            }*/

            /**
             * Exercise TWO:
             * 2- Write a program and ask the user to enter their name.
             * Use an array to reverse the name and then store the result in a new string.
             * Display the reversed name on the console.
             */
            /*Console.WriteLine("Enter your name");
            // get user input
            var userInput = Console.ReadLine();
            if (!(string.IsNullOrEmpty(userInput)))
            {
                char[] chars = userInput.ToCharArray();

                // reverse characters
                Array.Reverse(chars);

                var reversedName = new string(chars);

                Console.WriteLine($"Reversed name: {reversedName}");
            }*/

            /**
             * EXERCISE 3:
             * 3- Write a program and ask the user to enter 5 numbers.
             * If a number has been previously entered,
             * display an error message and ask the user to re-try.
             * Once the user successfully enters 5 unique numbers,
             * sort them and display the result on the console.
             */

            Console.WriteLine("Enter 5 unique numbers");
            var inputList = new List<int>();

            int i = 0;
            while (i < 5)  // Loop should run exactly 5 times
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();

                // Check for null or empty input
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid or empty input, please try again.");
                    continue;
                }

                try
                {
                    int convertedInput = Convert.ToInt32(input);

                    // Check for duplicates
                    if (inputList.Contains(convertedInput))
                    {
                        Console.WriteLine("Error! Value already exists, please enter a unique number.");
                        continue;
                    }

                    // Add the number to the list
                    inputList.Add(convertedInput);
                    i++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            }

            // Sort and display the result
            inputList.Sort();
            Console.WriteLine("Sorted unique numbers: " + string.Join(", ", inputList));

        }
    }
}
