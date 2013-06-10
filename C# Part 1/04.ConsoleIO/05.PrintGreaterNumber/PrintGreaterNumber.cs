using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PrintGreaterNumber
{
    class PrintGreaterNumber
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int biggerNumber = GetBiggerNumber(firstNumber, secondNumber);
            Console.WriteLine("The bigger number is: {0}", biggerNumber);
        }

        private static int GetBiggerNumber(int firstNumber, int secondNumber)
        {
            return firstNumber - ((firstNumber - secondNumber) & (firstNumber - secondNumber) >> 31);
        }
    }
}
