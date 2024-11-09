namespace Working_with_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // working with datetime in c#
            var dateTime = new DateTime(2015, 1, 1);
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
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
