namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create empty list
            /*List<int> numbers = new List<int>();*/

            // intialize list ahead of time
            var numbers = new List<int>() { 1, 2, 3, 4 };

            numbers.Add(1);

            // add more than one object to list
            numbers.AddRange(new int[3] { 5, 6, 7 }); // adding an array of integers to the list

            // iterate list
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Get Last index");
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            // count method
            Console.WriteLine("Count: " + numbers.Count);

            // Remove method
            /*numbers.Remove(1);*/
            /*foreach(var n in numbers)
            {
                if (n == 1)
                    numbers.Remove(n);
            }*/ // CANNOT MODIFY A LIST IN A FOREACH LOOP

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach(var number in numbers)
                Console.WriteLine(number);

        }
    }
}
