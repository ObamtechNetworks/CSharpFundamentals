namespace Exercises_Working_with_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1- Write a program that reads a text file and displays the number of words.
             */

            // use the File Class to read text file and then display word count
            var path = @"C:\Users\mbamidele\Documents\file.txt.txt";

            var texts = File.ReadAllText(path);

            var words = texts.Split(' ');

            Console.WriteLine("Total words: " + words.Length);
        }
    }
}
