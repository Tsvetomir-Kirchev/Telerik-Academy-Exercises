using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AddPositiveIntegrs
{
    class AddPositiveIntegers
    {
        static void Main(string[] args)
        {
            string firstNumber = "123";
            string secondNumber = "321";

            string result = AddNumbers(firstNumber, secondNumber);
            Console.WriteLine(result);
        }

        static string AddNumbers(string firstNumber, string secondNumber)
        {
            char[] firstNumberReversed = new char[firstNumber.Length];
            for (int i = 0; i < firstNumber.Length; i++)
            {
                firstNumberReversed[i] = firstNumber[firstNumber.Length - 1 - i];
            }
            string reversedFirstNumber = new string(firstNumberReversed);

            char[] secondNumberReversed = new char[secondNumber.Length];
            for (int j = 0; j < secondNumber.Length; j++)
            {
                secondNumberReversed[j] = secondNumber[secondNumber.Length - 1 - j];
            }
            string reversedSecondNumber = new string(secondNumberReversed);

            decimal sum = Decimal.Parse(reversedFirstNumber) + Decimal.Parse(reversedSecondNumber);
            return sum.ToString();
        }
    }
}
