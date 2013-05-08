using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CheckPointInCircle
{
    class CheckPointInCircle
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = Int32.Parse(Console.ReadLine());

            bool isInCircle = IsPointInCircle(x, y);
            if (isInCircle)
            {
                Console.WriteLine("Point ({0}, {1}) is in circle 0, 5", x, y);
            }
            else
            {
                Console.WriteLine("Point ({0}, {1}) is not in circle 0, 5", x, y);
            }
        }

        public static bool IsPointInCircle(int x, int y)
        {
            if ((x <= 5) && (y <= 5))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
