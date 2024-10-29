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
            var season = Season.Autumn;

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
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotions");
                    break;
                default:
                    Console.WriteLine("I don't understand that seasion");
                    break;
            }
        }
    }
}
