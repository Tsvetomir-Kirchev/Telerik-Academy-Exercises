using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertNumbersToCorrespondingText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of range <0-999>: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (number < 10)
            {
                Console.WriteLine(ConvertUnitsToText(number));
            }
            else if (number >= 10 && number <= 19)
            {
                Console.WriteLine(ConvertTeensToText(number));
            }
            else if (number >= 20 && number <= 99)
            {
                Console.WriteLine(ConvertDecimalsToText(number));
            }
            else if (number >= 100 && number <= 999)
            {
                Console.WriteLine(ConvertHundretsToText(number));
            }
            else
            {
                Console.WriteLine("Incorrect number!");
            }
        }

        static string ConvertUnitsToText(int unit)
        {
            string[] ones = new string[] 
            {
                "", "one", "two", "three", 
                "four", "five", "six", 
                "seven", "eight", "nine"
            };

            return ones[unit];
        }

        static string ConvertTeensToText(int teenNumber)
        {
            string[] teens = new string[]
            {
                "Ten", "Eleven", "Twelve", 
                "Thirteen", "Fourteen", "Fifteen",
                "Sixteen", "Seventeen", "Eighteen", "Nineteen"
            };

            return teens[teenNumber - 10];
        }

        static string ConvertDecimalsToText(int decimals)
        {
            string[] tens = new string[]
            {
                "", "", "twenty ", "thirty ", "fourty ",
                "fifty ", "sixty ", "seventy ",
                "eighty ", "nintey "
            };

            int units = decimals % 10;
            int decimalNumber = (decimals / 10);

            return tens[decimalNumber] + ConvertUnitsToText(units);
        }

        static string ConvertHundretsToText(int number)
        {
            string[] hundreds = new string[]
            {
                "", "one hundred ", "two hundred ", "three hundred ",
                "four hundred ", "five hundred ", "six hundred ",
                "seven hundred ", "eight hundred ", "nine hundred "
            };

            int units = number % 10;
            int decimals = (number / 10) % 10;
            int hundredsNumber = (number / 100) % 10;

            string decimalNumber = "" + decimals + "" + units;
            int castDecimalNumber = Int32.Parse(decimalNumber);

            string result = "";

            if (castDecimalNumber <= 9)
            {
                result = hundreds[hundredsNumber] + "and " +
                    ConvertUnitsToText(units);
            }
            else if (castDecimalNumber >= 10 && castDecimalNumber <= 19)
            {
                result = hundreds[hundredsNumber] + "and " +
                    ConvertTeensToText(castDecimalNumber);
            }
            else
            {
                result = hundreds[hundredsNumber] +
                    ConvertDecimalsToText(castDecimalNumber);
            }

            return result;
        }
    }
}
