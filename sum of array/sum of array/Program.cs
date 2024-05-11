using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3 };
            int sum = 0;


            
            for (int i=0;i<number.Length;i++)
            {
                sum = sum + number[i];

            }
            Console.WriteLine(sum); 
            Console.ReadKey();
            
        }
    }
}
