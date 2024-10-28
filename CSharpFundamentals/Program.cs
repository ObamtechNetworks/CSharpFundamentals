using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //difference between copying valuetypes and reference types
            var a = 10;
            var b = a;
            b++;
            // when you copy a value type into a variable, a copy of that value is copied
            // and stored in that variable in a new memory location
            // hence a completely independent variables (different from each other)
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // working with reference types
            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("{array1 element 1: {1}, array2 element 1: {1}", array1[0], array2[0]);
            // what has happened behind the hood, array is created in the heap and 
            // when array1 is copied to array2, array2 -> simply points to the same memory location of array1
            // therefore any changes made in array2 will reflect in array1 and vice versa
        }
    }
}
