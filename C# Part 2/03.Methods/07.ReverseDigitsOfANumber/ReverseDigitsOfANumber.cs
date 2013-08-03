using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseDigitsOfANumber
{
    class ReverseDigitsOfANumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            Console.Write("The numebr with reversed digits: ");
            ReverseDigits(number);
        }

        public static void ReverseDigits(string number)
        {
            char[] digits = number.ToCharArray();
            int index = digits.Length;
            char[] reverseDigits = new char[index];

            for (int i = 0; i < index; i++)
            {
                reverseDigits[index - i - 1] = digits[i];
            }

            PrintReversedNumber(reverseDigits);
        }

        private static void PrintReversedNumber(char[] number)
        {
            foreach (var item in number)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
