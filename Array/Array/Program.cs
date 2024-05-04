using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int size;
            Console.WriteLine("Enter the Size of array:");
            size = int.Parse(Console.ReadLine());
            string[] almighty= new string[size];

            Console.WriteLine("\n");

            Console.WriteLine("Enter the Name of your friends:");
            for (int i=0;i< size; i++)
            {
               almighty[i]= Console.ReadLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine("Here is the list of your friends:");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(almighty[i]);
            }

            Console.ReadKey();
        }
    }
}
