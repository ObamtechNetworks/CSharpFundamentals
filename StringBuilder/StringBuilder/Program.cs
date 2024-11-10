
namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder("Hello World");
            /*Console.WriteLine(builder);*/
            

            // the append returns a stringbuilder, therefore we can chain all these methods together
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]); // accessing chars in builder by index
        }
    }
}
