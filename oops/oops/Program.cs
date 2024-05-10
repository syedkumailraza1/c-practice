using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Program
    {
        class Area
        {
           public int rectangle (int width,int lenght)
            {
                return width * lenght;
            }

          public  int triangle(int b, int height)
            {
                return (b * height) /2;
            }

        }

        static void Main(string[] args)
        {
            Area area = new Area();
            Console.WriteLine("Enter 1 to check area of triangle and 2 for area of rectangle:");
            int n = Convert.ToInt32( Console.ReadLine());
            if(n == 1)
            Console.WriteLine("Area of Triangle is "+area.triangle(10, 20));
            else
            Console.WriteLine("Area of Rectanle is " + area.rectangle(20, 10));

            namespace
            Console.ReadKey();
        }
    }
}
