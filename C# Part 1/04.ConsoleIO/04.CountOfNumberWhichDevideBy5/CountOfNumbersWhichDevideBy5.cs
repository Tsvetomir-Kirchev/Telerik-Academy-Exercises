using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountOfNumberWhichDevideBy5
{
    class CountOfNumbersWhichDevideBy5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int count = GetCount(firstNumber, secondNumber);
            Console.WriteLine("p({0}, {1}) = {2}", firstNumber, secondNumber, count);
        }

        private static int GetCount(int firstNumber, int secondNumber)
        {
            int count = 0;

            if (secondNumber >= firstNumber)
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
