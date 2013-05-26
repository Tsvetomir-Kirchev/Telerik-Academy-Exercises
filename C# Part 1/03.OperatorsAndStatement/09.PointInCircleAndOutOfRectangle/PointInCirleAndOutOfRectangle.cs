using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PointInCircleAndOutOfRectangle
{
    class PointInCirleAndOutOfRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = Double.Parse(Console.ReadLine());

            if ((x > -1 && x < 5) && (y > -1 || y < 1))
            {
                Console.WriteLine("The point {0},{1} is inside the circle.", x, y);
            }
            else
            {
                Console.WriteLine("The point {0},{1} is not inside the circle.", x, y);
            }
        }
    }
}
