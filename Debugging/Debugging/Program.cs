namespace Debugging
{
    internal class Program
    {
        // enter debug mode: F5
        // step over F10
        // step into: F11
        static void Main(string[] args)
        {
           // A sample code with bug 
           var numbers = new List<int>();
           var smallest = GetSmallests(null, 3);

           foreach (var number in smallest)
           {
               Console.WriteLine(number);
           }

        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            // add edge case to prevent overflow exception
            // check if count is not greater than number of elements in list or list is null
            if (list == null)
                throw new ArgumentException("list")
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list");

            //create a copy of list
            var buffer = new List<int>(list);
            var smallest = new List<int>();

            while (smallest.Count < count)
            {
                var min = GetSmallest(buffer);
                smallest.Add(min);
                buffer.Remove(min); // side effects, list is mutated
            }

            return smallest;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0]; // list could be empty.

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
