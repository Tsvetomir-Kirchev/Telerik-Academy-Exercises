using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CalculateNFactorial
{
    class CalculateNFactorial
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("{0}: {1}", i, Factorial(i));
            }
        }

        public static string Factorial(int n)
        {
            string result = "1";
            for (int i = 2; i <= n; i++)
            {
                result = Multiply(result, i.ToString());
            }
            return result;
        }

        public static string Sum(string firstNumber, string secondNumber)
        {
            string result = "";
            int length = Math.Max(firstNumber.Length, secondNumber.Length);
            byte resultDigit = 0;
            bool isOne = false;
            for (int i = 0; i < length; i++)
            {
                if (isOne)
                {
                    resultDigit++;
                }
                if (firstNumber.Length - i > 0)
                {
                    resultDigit += byte.Parse(firstNumber[firstNumber.Length - i - 1].ToString());
                }
                if (secondNumber.Length - i > 0)
                {
                    resultDigit += byte.Parse(secondNumber[secondNumber.Length - i - 1].ToString());
                }
                if (resultDigit > 9)
                {
                    isOne = true;
                    resultDigit -= 10;
                }
                else
                {
                    isOne = false;
                }
                result = resultDigit + result;
                resultDigit = 0;
            }
            if (isOne)
            {
                result = "1" + result;
            }
            return result;
        }

        public static string Multiply(string number, byte digit)
        {
            string result = "";
            byte resultDigit = digit;
            byte carryNumber = 0;
            for (int i = number.Length - 1; i > -1; i--)
            {
                resultDigit *= byte.Parse(number[i].ToString());
                resultDigit += carryNumber;
                if (resultDigit > 9)
                {
                    carryNumber = (byte)(resultDigit / 10);
                    resultDigit = (byte)(resultDigit % 10);
                }
                else
                {
                    carryNumber = 0;
                }
                result = resultDigit.ToString() + result;
                resultDigit = digit;
            }
            if (carryNumber > 0)
            {
                result = carryNumber.ToString() + result;
            }
            return result;
        }

        public static string Multiply(string firstNumber, string secondNumber)
        {
            string result = "0";
            string medialResult;
            for (int i = 0; i < secondNumber.Length; i++)
            {
                byte secondNumberDigit = byte.Parse(secondNumber[
                        secondNumber.Length - i - 1].ToString());
                medialResult = Multiply(firstNumber, secondNumberDigit);
                medialResult = medialResult + new string('0', i);
                result = Sum(result, medialResult);
            }
            return result;
        }
    }
}
