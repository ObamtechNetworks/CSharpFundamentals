using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int hour = 30;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else Console.WriteLine("It's evening.");*/

            /* bool isGoldCustomer = true;

             float price = (isGoldCustomer) ? 19.95f : 29.95f;
             Console.WriteLine(price);*/

            // SWITCH CASE
            //var season = Season.Autumn;

            /*switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("We've got promotion");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach");
                    break;
                default:
                    Console.WriteLine("I don't umderstand that season");
                    break;
            }*/

            //HANDLING TWO SWITCH CASES ---> Case A  OR Case B
            /* switch (season)
             {
                 case Season.Autumn:
                 case Season.Summer:
                     Console.WriteLine("We've got promotions");
                     break;
                 default:
                     Console.WriteLine("I don't understand that seasion");
                     break;
             }*/

            //RANDOM CLASS IN CSHARP
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 10));
            //}

            // GENERATE RANDOM CHARACTERS using ascii codes
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //    Console.Write((char)random.Next(97, 122));
            //Console.WriteLine();

            // GENERATE CHARACTERS MORE EXPRSSIVE WAY
            /*var random = new Random();
            for (var i = 0; i < 10; i++)
                Console.Write((char)('a' + random.Next(0, 26)));
            Console.WriteLine();*/

            const int passwordLength = 10;
            var random = new Random();
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);

        }
    }
}
