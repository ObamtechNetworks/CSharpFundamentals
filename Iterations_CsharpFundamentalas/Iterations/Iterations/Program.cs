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

            var name = "John Smith";
            // using for loop
            /*for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }*/

            //using FOREACH LOOP

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
