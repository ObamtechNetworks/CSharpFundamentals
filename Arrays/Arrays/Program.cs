namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an array of integers
            var numbers = new [] { 3, 7, 9, 2, 14, 6 };

            // length
            Console.WriteLine("Effect of length");
            Console.WriteLine(numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Effect of IndexOf()");
            Console.WriteLine("Index of 9: " + index);

            // clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number); // as an array of numbers clearing means setting numbers to 0
                // for booleans clearing means setting all True to False
                // for objects clearing means setting values to null
            }

            // copy()
            Console.WriteLine("Effect of Copy()");
            int[] destinationArray = new int[3];
            Array.Copy(numbers, destinationArray, 3); // copy first 3 elements into the destination array
            foreach(var n in destinationArray)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

             
        }
    }
}
