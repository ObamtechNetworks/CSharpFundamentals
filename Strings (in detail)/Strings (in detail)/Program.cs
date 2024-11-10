namespace Strings__in_detail_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Michael Bamidele ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf((' '));
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            // achieve same thing using split
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            // Using Replace
            Console.WriteLine(fullName.Replace("Michael", "Mike"));

            // dealing with null values => isNull or whitespace, isnullorempty
            if (string.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            // converting string to numbers
            var str = "25";
            var age = Convert.ToByte(str); // only one byte required to store someone's age
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0")); // convert to currency



        }
    }
}
