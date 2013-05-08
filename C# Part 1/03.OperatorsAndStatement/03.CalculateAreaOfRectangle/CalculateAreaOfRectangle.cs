using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CalculateAreaOfRectangle
{
    class CalculateAreaOfRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("width = ");
            int width = Int32.Parse(Console.ReadLine());
            Console.Write("height = ");
            int height = Int32.Parse(Console.ReadLine());

            int area = CalculateArea(width, height);
            Console.WriteLine("The area of rectangle with width = {0} and height = {1} is {2}",
                width, height, area);
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
}
