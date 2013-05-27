using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PerimeterAndAreaOfCircle
{
    class PerimeterAndAreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());

            double area = CalculateArea(r);
            double perimeter = CalculatePerimeter(r);

            Console.WriteLine("Area: {0}, Perimeter: {1}", area, perimeter);
        }

        private static double CalculateArea(double r)
        {
            return Math.PI * (r * r);
        }

        private static double CalculatePerimeter(double r)
        {
            return 2 * (Math.PI * r);
        }
    }
}
