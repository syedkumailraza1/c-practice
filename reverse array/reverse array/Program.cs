using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3,4 };
            Array.Reverse(number);
            foreach(int i in number)
            {
                Console.Write(i);
            }
            
            Console.ReadLine();
        }
    }
}
