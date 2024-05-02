using System;

namespace Math_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.Sqrt(num)
            int num = 16;
            Console.WriteLine("Square root of {0} is: " + Math.Sqrt(num), num);

            //Math.Abs(-92)
            int x = -92;
            Console.WriteLine("Absolute of {0} is: " + Math.Abs(x), x);

            //Math.Round()
            double a = 9.2;
            Console.WriteLine("The round of {0} is: " + Math.Round(a), a);
            Console.ReadKey();
        }
    }
}
