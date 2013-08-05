using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertDecimalToBinary
{
    class ConvertDecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = Int32.Parse(Console.ReadLine());

            ConvertDecimalNumberToBinary(decimalNumber);
        }

        public static void ConvertDecimalNumberToBinary(int decimalNumber)
        {
            StringBuilder reversedBinaryNumber = new StringBuilder();
            int number = decimalNumber;
            while (decimalNumber != 0)
            {
                if (decimalNumber % 2 == 0)
                {
                    reversedBinaryNumber.Append("0");
                }
                else
                {
                    reversedBinaryNumber.Append("1");
                }

                decimalNumber /= 2;
            }

            StringBuilder binaryNumber = new StringBuilder();
            for (int i = reversedBinaryNumber.Length - 1; i >= 0; i--)
            {
                binaryNumber.Append(reversedBinaryNumber[i]);
            }

            Console.WriteLine("Binary representation of {0} is {1}",
                number, binaryNumber);
        }
    }
}
