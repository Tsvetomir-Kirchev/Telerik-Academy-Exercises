using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeValueOfTwoIntegers
{
    class ExchangeValueOfTwoIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("first number = ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("second number = ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("first number: {0}, second number {1}", firstNumber, secondNumber);
            if (firstNumber > secondNumber)
            {
                firstNumber ^= secondNumber;
                secondNumber ^= firstNumber;
                firstNumber ^= secondNumber;
            }
            Console.WriteLine("first number: {0}, second number {1}", firstNumber, secondNumber);
        }
    }
}
