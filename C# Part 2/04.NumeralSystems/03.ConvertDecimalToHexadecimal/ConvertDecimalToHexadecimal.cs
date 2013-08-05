using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ConvertDecimalToHexadecimal
{
    class ConvertDecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = Int32.Parse(Console.ReadLine());

            DecimalToHexadecimal(decimalNumber);
        }

        public static void DecimalToHexadecimal(int decimalNumber)
        {
            StringBuilder reversedHexaDecimalNumber = new StringBuilder();
            int number;
            while (decimalNumber != 0)
            {
                number = decimalNumber % 16;
                reversedHexaDecimalNumber.Append(HexadecimalCharacter(number));
                decimalNumber /= 16;
            }

            StringBuilder hexaDecimalNumber = new StringBuilder();
            for (int i = reversedHexaDecimalNumber.Length - 1; i >= 0; i--)
            {
                hexaDecimalNumber.Append(reversedHexaDecimalNumber[i]);
            }
            Console.WriteLine(hexaDecimalNumber);
        }

        private static char HexadecimalCharacter(int num)
        {
            char character = ' ';
            switch (num)
            {
                case 0:
                    character = '0';
                    break;
                case 1:
                    character = '1';
                    break;
                case 2:
                    character = '2';
                    break;
                case 3:
                    character = '3';
                    break;
                case 4:
                    character = '4';
                    break;
                case 5:
                    character = '5';
                    break;
                case 6:
                    character = '6';
                    break;
                case 7:
                    character = '7';
                    break;
                case 8:
                    character = '8';
                    break;
                case 9:
                    character = '9';
                    break;
                case 10:
                    character = 'A';
                    break;
                case 11:
                    character = 'B';
                    break;
                case 12:
                    character = 'C';
                    break;
                case 13:
                    character = 'D';
                    break;
                case 14:
                    character = 'E';
                    break;
                case 15:
                    character = 'F';
                    break;
                default:
                    Console.WriteLine("Error. The input chars in HexadecimalCharacter are not correct!");
                    break;
            }
            return character;
        }
    }
}
