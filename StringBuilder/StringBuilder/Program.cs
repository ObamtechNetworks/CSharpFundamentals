
namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder("Hello World");
            /*Console.WriteLine(builder);*/
            

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]); // accessing chars in builder by index
        }
    }
}
