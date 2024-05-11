using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp=num;
            
            while (num != 0) {
                rev = rev * 10 + num % 10;
                num = num/10;
            }
            num = temp;

            if (num == rev)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }



            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
