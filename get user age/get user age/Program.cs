using System;

namespace get_user_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is: " + age);
            Console.ReadKey();
        }
    }
}
