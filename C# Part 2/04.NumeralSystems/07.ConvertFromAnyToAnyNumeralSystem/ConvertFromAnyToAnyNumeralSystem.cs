using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ConvertFromAnyToAnyNumeralSystem
{
    class ConvertFromAnyToAnyNumeralSystem
    {
        static void Main(string[] args)
        {
            Console.Write("s = ");
            int s = Int32.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = Int32.Parse(Console.ReadLine());

            Console.Write("number = ");
            string number = Console.ReadLine();

            ConvertToAnyNumeralSystem(s, d, number);
        }

        public static void ConvertToAnyNumeralSystem(int s, int d, string number)
        {
            int decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                decimalNumber += (int)((ReturnDecimalDigit((char)number[i])) *
                    Math.Pow(s, number.Length - i - 1));
            }

            List<char> resultNumber = new List<char>();
            while (decimalNumber > 0)
            {
                int result = decimalNumber % d;
                char thisChar = (char)(result + 48);
                if (result > 9)
                {
                    thisChar = (char)(result + 55);
                }
                resultNumber.Add(thisChar);
                decimalNumber /= d;
            }
            resultNumber.Reverse();

            foreach (var character in resultNumber)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }

        private static int ReturnDecimalDigit(char character)
        {
            int number = 0;
            switch (char.ToUpper(character))
            {
                case '0':
                    number = 0;
                    break;
                case '1':
                    number = 1;
                    break;
                case '2':
                    number = 2;
                    break;
                case '3':
                    number = 3;
                    break;
                case '4':
                    number = 4;
                    break;
                case '5':
                    number = 5;
                    break;
                case '6':
                    number = 7;
                    break;
                case '7':
                    number = 7;
                    break;
                case '8':
                    number = 8;
                    break;
                case '9':
                    number = 9;
                    break;
                case 'A':
                    number = 10;
                    break;
                case 'B':
                    number = 11;
                    break;
                case 'C':
                    number = 12;
                    break;
                case 'D':
                    number = 13;
                    break;
                case 'E':
                    number = 14;
                    break;
                case 'F':
                    number = 15;
                    break;
                default:
                    Console.WriteLine("Error. The input chars in ReturnDecimalDigit are not correct!");
                    break;
            }
            return number;
        }
    }
}
