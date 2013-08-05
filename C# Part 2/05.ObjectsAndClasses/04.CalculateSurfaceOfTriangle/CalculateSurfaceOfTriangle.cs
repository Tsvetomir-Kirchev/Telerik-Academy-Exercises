using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CalculateSurfaceOfTriangle
{
    class CalculateSurfaceOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATE SURFACE OT A TRIANGLE");
            Console.WriteLine();
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("MENU");
                Console.WriteLine(" 1.BY SIDE AND ALTITUDE");
                Console.WriteLine(" 2.BY THREE SIDES");
                Console.WriteLine(" 3.BY TWO SIDE AND AN ANGLE BETWEEN THEM");
                Console.WriteLine(" 4.EXIT");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Please enter a number between 1 and 4");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                }

                Menu(choice);
            }
        }

        public static void Menu(int choice)
        {
            switch (choice)
            {
                case 1:
                    CalculateSurfaceBySideAndAltitude();
                    break;
                case 2:
                    CalculateSurfaceByThreeSides();
                    break;
                case 3:
                    CalculateSurfaceByTwoSidesAndAngle();
                    break;
                case 4:
                    Console.WriteLine("GOOD BYE!");
                    break;
                default:
                    break;
            }
        }

        private static void CalculateSurfaceBySideAndAltitude()
        {
            Console.Write("a = ");
            double side = Double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double altitude = Double.Parse(Console.ReadLine());

            double surface = Math.Sqrt(side * altitude);

            Console.WriteLine("The surface is: {0}", surface);
            Console.WriteLine();
        }

        private static void CalculateSurfaceByThreeSides()
        {
            Console.Write("a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = Double.Parse(Console.ReadLine());

            double P = Math.Sqrt(a + b + c);
            double surface = Math.Sqrt(P * Math.Abs(P - a) * Math.Abs(P - b) * Math.Abs(P - c));

            Console.WriteLine("The surface is: {0}", surface);
            Console.WriteLine();
        }

        private static void CalculateSurfaceByTwoSidesAndAngle()
        {
            Console.Write("a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("angle = ");
            double angle = Double.Parse(Console.ReadLine());

            double sinGame = Math.Sin((Math.PI * angle / 180));
            double surface = (a * b * sinGame) * 0.5;

            Console.WriteLine("The surface is: {0}", surface);
            Console.WriteLine();
        }
    }
}
