using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ConvertBinaryToHexadecimal
{
    class ConvertBinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binaryNumber = Console.ReadLine();

            ConvertToHexadecimalFromBinary(binaryNumber);
        }

        public static void ConvertToHexadecimalFromBinary(string binaryNumber)
        {
            StringBuilder hexaDdecimalNumber = new StringBuilder();
            binaryNumber = binaryNumber.PadLeft(32, '0');

            StringBuilder fourBits = new StringBuilder();

            int counter = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                fourBits.Append(binaryNumber[i]);
                counter++;
                if (counter == 4)
                {
                    counter = 0;
                    hexaDdecimalNumber.Append(ReturnHexSymbol(fourBits.ToString()));
                    fourBits.Clear();
                }
            }

            Console.WriteLine("0x" + hexaDdecimalNumber);
        }

        private static string ReturnHexSymbol(string character)
        {
            string number = "";

            switch (character)
            {
                case "0000":
                    number = "0";
                    break;
                case "0001":
                    number = "1";
                    break;
                case "0010":
                    number = "2";
                    break;
                case "0011":
                    number = "3";
                    break;
                case "0100":
                    number = "4";
                    break;
                case "0101":
                    number = "5";
                    break;
                case "0110":
                    number = "6";
                    break;
                case "0111":
                    number = "7";
                    break;
                case "1000":
                    number = "8";
                    break;
                case "1001":
                    number = "9";
                    break;
                case "1010":
                    number = "A";
                    break;
                case "1011":
                    number = "B";
                    break;
                case "1100":
                    number = "C";
                    break;
                case "1101":
                    number = "D";
                    break;
                case "1110":
                    number = "E";
                    break;
                case "1111":
                    number = "F";
                    break;
                default:
                    break;
            }
            return number;
        }
    }
}
