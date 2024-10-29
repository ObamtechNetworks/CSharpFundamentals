namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* // dipslays even number from 1 to 10
             for (int i = 1; i < 10; i++)
             {
                 if (i % 2 == 0)
                 {
                     Console.WriteLine(i);
                 }
             }

             Console.WriteLine("Reverse...");
             for (int i = 10; i >= 1; i--)
             {
                 if (i % 2 == 0)
                 {
                     Console.WriteLine(i);  
                 }
             }*/

            // UNDERSTANDING FOREACH LOOP (comparing with for loop)

            //var name = "John Smith";
            // using for loop
            /*for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }*/

            //using FOREACH LOOP

            /* foreach (var character in name)
             {
                 Console.WriteLine(character);
             }*/

            //foreach ON ARRAYS OF NUMBERS
            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // WHILE LOOP
            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
                
            //    i++;
            //}

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                //if (String.IsNullOrWhiteSpace(input))
                //{
                //    //if input is null or whitespace, break and jump out of the loop
                //    Console.WriteLine("You entered nothing! \nBye!... Program Ended..");
                //    break;
                //}
                //Console.WriteLine(string.Format("Echo: {0}", input));
                //Console.WriteLine();

                // another method
                if (!String.IsNullOrWhiteSpace(input)) //if what user typed is not empty str or enter
                {
                    Console.WriteLine(@"Echo: " + input);
                    continue; // loop starts again, code below is skipped
                }
                Console.WriteLine("Bye...");
                break;
            }
        }
    }
}
