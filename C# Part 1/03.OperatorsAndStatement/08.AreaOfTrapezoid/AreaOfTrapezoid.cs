using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AreaOfTrapezoid
{
    class AreaOfTrapezoid
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("h = ");
            int h = Int32.Parse(Console.ReadLine());

            int area = CalculateArea(a, b, h);
            Console.WriteLine("The are of the trapezoid is {0}", area);
        }

        public static int CalculateArea(int a, int b, int h)
        {
            int area = (a + b / 2) * h;
            return area;
        }
    }
}
