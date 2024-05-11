using System;

namespace max_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4 };
            int maxNum = 0;

            for (int i = 1; i < number.Length; i++) // Start from index 1
            {
                if (number[i] > number[maxNum])
                {
                    maxNum = i;
                }
            }

            Console.WriteLine("Index of the maximum element: " + maxNum);
            Console.WriteLine("Maximum element: " + number[maxNum]);
            Console.ReadKey();
        }
    }
}
