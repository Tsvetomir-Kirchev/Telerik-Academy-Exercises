using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ConvertHexadecimalToDecimal
{
    class ConvertHexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Write a hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine();

            char[] hex = hexadecimalNumber.ToCharArray();
            ConvertHexadecimalNumberToDecimal(hex);
        }

        public static void ConvertHexadecimalNumberToDecimal(char[] hex)
        {
            int decimalNumber = 0;
            int multiplayer = 1;
            int integerFromHex = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                integerFromHex = ReturnIntFromHex(hex[hex.Length - i - 1]);
                if (i != 0)
                {
                    multiplayer *= 16;
                }
                if (i == 0)
                {
                    decimalNumber += integerFromHex;
                }
                else
                {
                    decimalNumber += (integerFromHex * multiplayer);
                }
            }
            Console.WriteLine(decimalNumber);
        }

        private static int ReturnIntFromHex(char hex)
        {
            int number = 0;
            switch (char.ToUpper(hex))
            {
                case '0':
                    break;
                case '1':
                    number += 1;
                    break;
                case '2':
                    number += 2;
                    break;
                case '3':
                    number += 3;
                    break;
                case '4':
                    number += 4;
                    break;
                case '5':
                    number += 5;
                    break;
                case '6':
                    number += 6;
                    break;
                case '7':
                    number += 7;
                    break;
                case '8':
                    number += 8;
                    break;
                case '9':
                    number += 9;
                    break;
                case 'A':
                    number += 10;
                    break;
                case 'B':
                    number += 11;
                    break;
                case 'C':
                    number += 12;
                    break;
                case 'D':
                    number += 13;
                    break;
                case 'E':
                    number += 14;
                    break;
                case 'F':
                    number += 15;
                    break;
                default:
                    Console.WriteLine("Error! The Hexadecimal number is wrong!");
                    break;
            }
            return number;
        }
    }
}
