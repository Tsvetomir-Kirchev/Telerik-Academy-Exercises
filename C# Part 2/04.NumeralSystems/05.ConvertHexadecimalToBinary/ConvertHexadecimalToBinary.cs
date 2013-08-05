using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ConvertHexadecimalToBinary
{
    class ConvertHexadecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine();

            HexadecimalToBinary(hexadecimalNumber);
        }

        public static void HexadecimalToBinary(string hexadecimalNnumber)
        {
            char[] hex = hexadecimalNnumber.ToCharArray();
            StringBuilder binaryNumber = new StringBuilder();

            for (int i = 0; i < hex.Length; i++)
            {
                binaryNumber.Append(ReturnBinaryFromHexSymbol(hex[i]));
            }

            Console.WriteLine(binaryNumber);
        }

        private static string ReturnBinaryFromHexSymbol(char character)
        {
            string number = "";
            switch (char.ToUpper(character))
            {
                case '0':
                    number = "0000";
                    break;
                case '1':
                    number = "0001";
                    break;
                case '2':
                    number = "0010";
                    break;
                case '3':
                    number = "0011";
                    break;
                case '4':
                    number = "0100";
                    break;
                case '5':
                    number = "0101";
                    break;
                case '6':
                    number = "0110";
                    break;
                case '7':
                    number = "0111";
                    break;
                case '8':
                    number = "1000";
                    break;
                case '9':
                    number = "1001";
                    break;
                case 'A':
                    number = "1010";
                    break;
                case 'B':
                    number = "1011";
                    break;
                case 'C':
                    number = "1100";
                    break;
                case 'D':
                    number = "1101";
                    break;
                case 'E':
                    number = "1110";
                    break;
                case 'F':
                    number = "1111";
                    break;
                default:
                    Console.WriteLine("Error. The input chars in HexadecimalCharacter are not correct!");
                    break;
            }
            return number;
        }
    }
}
