using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FindBiggestNumber
{
    class FindBiggestNumber
    {
        static void Main(string[] args)
        {
            Console.Write("First Number = ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Second Number = ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            int thirdNumber = Int32.Parse(Console.ReadLine());

            int biggerNumber = GetBiggestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("The bigger number is: {0}", biggerNumber);
        }

        private static int GetBiggestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int biggerNumber = firstNumber;
            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                biggerNumber = firstNumber;
            }
            else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
            {
                biggerNumber = secondNumber;
            }
            else
            {
                biggerNumber = thirdNumber;
            }

            return biggerNumber;
        }
    }
}
