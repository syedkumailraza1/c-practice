using System;

namespace reverse_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string name = Console.ReadLine();
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string (charArray);
            if(reversed == name)
            {
                Console.WriteLine("Palindrome String");
            }
            else
            {
                Console.WriteLine("Not a Palindrome String");
            }
            Console.ReadKey();
        }
    }
}
