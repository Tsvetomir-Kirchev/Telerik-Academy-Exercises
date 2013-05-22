using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ModifyGivenBit
{
    class ModifyGivenBit
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("v (0 or 1) = ");
            int v = Int32.Parse(Console.ReadLine());
            Console.Write("p = ");
            int position = Int32.Parse(Console.ReadLine());

            int modifiedNumber = ModifyBit(number, v, position);
            Console.WriteLine("Number {0} after modified bit {1} with value {2} is {3}",
                number, position, v, modifiedNumber);
        }

        private static int ModifyBit(int number, int v, int position)
        {
            int modifiedNumber = 0;

            // TODO: Implement the logic

            return modifiedNumber;
        }
    }
}
