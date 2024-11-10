namespace Working_with_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // working with datetime in c#
            /*var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            // Date objects are immutable
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            // Formatting datetime into string
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            // dispaly both date and time
            Console.WriteLine(now.ToString());
            // specify format
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));*/

            // Time span
            // Time span represents a length of time
            var timeSpan = new TimeSpan(1, 2, 3); // h m secs
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1); /// using static methods

            // getting timespan from date arithmetics
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // timespan also is immutable
            // methods

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // becomes 1, 10, 3
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // converting timespan to string using ToString methd
            Console.WriteLine("ToString " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
