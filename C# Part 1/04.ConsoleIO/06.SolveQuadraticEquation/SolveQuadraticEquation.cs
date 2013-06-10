using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SolveQuadraticEquation
{
    class SolveQuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = Int32.Parse(Console.ReadLine());

            double D = (b * b) - (4 * a * c);

            if (D < 0)
            {
                Console.WriteLine("The quadratic equation do not have real roots.");
            }
            else if (D == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("The quadratic equation has one real root: {0}", x);
            }
            else
            {
                double x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("The quadratic equation has 2 real roots:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}
