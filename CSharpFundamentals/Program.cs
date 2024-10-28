using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1, 
        RegisterAirMail = 2,
        Express = 3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* var john = new Person();
             john.FirstName = "John";
             john.LastName = "Smith";
             john.Introduce();

             Calculator calculator = new Calculator();
             var result = calculator.Add(1, 2);
             Console.WriteLine(result);

             Console.WriteLine("================ARRAYS==============");
             var numbers = new int[3];
             numbers[0] = 1;
             Console.WriteLine(numbers[0]);
             Console.WriteLine(numbers[1]);
             Console.WriteLine(numbers[2]);

             var flags = new bool[3];
             flags[0] = true;

             Console.WriteLine(flags[0]);
             Console.WriteLine(flags[1]);
             Console.WriteLine(flags[2]); // uinitialized parts of arrays are set to 0 or false

             var names = new string[3] { "Jack", "John", "Mary" };
             Console.WriteLine(names[0]);
             Console.WriteLine(names[1]);
             Console.WriteLine(names[2]);

             Console.WriteLine("stringBackslash\\");

             // Verbatim strings
             string path = "c:\\projects\\project1\\folder";
             // using verbatim
             string verbatimPath = @"c:\projects\project1\folder";
             Console.WriteLine(string.Format("Path1 -> {0} \nPath2 -> {1}", path, verbatimPath));

            var firstName = "Michael";
            var lastName = "Bamidele";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is  {0} {1}", firstName, lastName);

            Console.WriteLine("String.join method");
            var names = new string[] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);

            var text = @"Hi  John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder3";
            Console.WriteLine(text);
            */

            // working with enums
            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine((int)method); // cast to method value

            //convert or cast number to method
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // casting

            Console.WriteLine(method.ToString()); // using ToString to do that
            // can work without without ToString (if using Console.WriteLine)

            // what if we have a string and want to convert or parse to an enum?
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
