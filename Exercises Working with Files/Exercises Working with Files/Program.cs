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
            /*var path = @"C:\Users\mbamidele\Documents\file.txt.txt";

            var texts = File.ReadAllText(path);

            var words = texts.Split(' ');

            Console.WriteLine("Total words: " + words.Length);*/

            /**
             * 2- Write a program that reads a text file
             * and displays the longest word in the file.
             */

            // use the File Class to read text file and then display word count
            var path = @"C:\Users\mbamidele\Documents\file.txt.txt";

            var texts = File.ReadAllText(path);

            var words = texts.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var longestWord = "";
            // determine the longest word in the word list
                foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            Console.WriteLine("Longest word: " + longestWord);
        }
    }
}
