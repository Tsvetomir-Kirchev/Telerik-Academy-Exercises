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

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            int modifiedNumber = ModifyBit(number, v, position);
            Console.WriteLine(Convert.ToString(modifiedNumber, 2).PadLeft(32, '0'));
        }

        private static int ModifyBit(int number, int v, int position)
        {
            int modifiedNumber = number;

            if (v == 0)
            {
                modifiedNumber = (~(1 << position) & number);
            }
            else
            {
                int mask = v << position;
                modifiedNumber = modifiedNumber & ~(mask);
                modifiedNumber = (modifiedNumber | mask);
            }

            return modifiedNumber;
        }
    }
}
