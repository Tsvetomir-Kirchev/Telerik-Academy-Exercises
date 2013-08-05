using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertBinaryToDecimal
{
    class ConvertBinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary number: ");
            string binaryNumber = Console.ReadLine();

            char[] bits = binaryNumber.ToCharArray();
            ConvertBinaryNumberToDecimal(bits);
        }

        public static void ConvertBinaryNumberToDecimal(char[] bits)
        {
            int decimalNumber = 0;
            int multiplayer = 1;
            for (int i = 0; i < bits.Length; i++)
            {
                if (i != 0)
                {
                    multiplayer *= 2;
                }
                if (bits[bits.Length - 1 - i] == '1')
                {
                    if (i == 0)
                    {
                        decimalNumber += 1;
                    }
                    else
                    {
                        decimalNumber += multiplayer;
                    }
                }
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
