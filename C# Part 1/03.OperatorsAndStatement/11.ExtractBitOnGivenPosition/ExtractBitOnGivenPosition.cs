using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBitOnGivenPosition
{
    class ExtractBitOnGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("i = ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int bitPosition = Int32.Parse(Console.ReadLine());

            int bitValue = GetValueOfBit(number, bitPosition);
            Console.WriteLine("The value of bit {0} of number {1} is {2}",
                bitPosition, number, bitValue);
        }

        private static int GetValueOfBit(int number, int bitPosition)
        {
            int bitValue = 0;
            int mask = 1 << bitPosition;

            int result = number & mask;
            if (result != 0)
            {
                bitValue = 1;
            }
            else
            {
                bitValue = 0;
            }

            return bitValue;
        }
    }
}
