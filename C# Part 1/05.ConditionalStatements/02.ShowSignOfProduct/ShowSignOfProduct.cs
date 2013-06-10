using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ShowSignOfProduct
{
    class ShowSignOfProduct
    {
        static void Main(string[] args)
        {
            ShowSign();
        }

        private static void ShowSign()
        {
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = Int32.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product is 0!");
                return;
            }
            if ((a < 0 && b < 0) && c > 0)
            {
                Console.WriteLine("+");
            }
            else if ((a < 0 && c < 0) && b > 0)
            {
                Console.WriteLine("+");
            }
            else if ((b < 0 && c < 0) && a > 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
