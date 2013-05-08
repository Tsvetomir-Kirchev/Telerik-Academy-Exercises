using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FindThirdBit
{
    class FindThirdBit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            bool isOne = IsThirdBit1(number);

            if (isOne)
            {
                Console.WriteLine("Third bit of {0} is 1", number);
            }
            else
            {
                Console.WriteLine("Third bit of {0} is 0", number);
            }
        }

        public static bool IsThirdBit1(int number)
        {
            bool result = false;

            int mask = 4;
            int r = number & mask;

            if (r != 0)
            {
                result = true;
            }

            return result;
        }
    }
}
