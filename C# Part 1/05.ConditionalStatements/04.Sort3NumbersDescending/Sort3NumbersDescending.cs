using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort3NumbersDescending
{
    class Sort3NumbersDescending
    {
        static void Main(string[] args)
        {
            Console.Write("First Number = ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Second Number = ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            int thirdNumber = Int32.Parse(Console.ReadLine());


            SortAndPrint(ref firstNumber, ref secondNumber, ref thirdNumber);
        }

        private static void SortAndPrint(ref int firstNumber, ref int secondNumber, ref int thirdNumber)
        {
            int highNumber;
            int middleNumber;
            int lowNumber;

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                highNumber = firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                highNumber = secondNumber;
            }
            else
            {
                highNumber = thirdNumber;
            }

            if ((firstNumber < secondNumber && firstNumber > thirdNumber) ||
                (firstNumber > secondNumber && firstNumber < thirdNumber))
            {
                middleNumber = firstNumber;
            }
            else if ((secondNumber < firstNumber && secondNumber > thirdNumber) ||
                (secondNumber > firstNumber && secondNumber < thirdNumber))
            {
                middleNumber = secondNumber;
            }
            else
            {
                middleNumber = thirdNumber;
            }

            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                lowNumber = firstNumber;
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                lowNumber = secondNumber;
            }
            else
            {
                lowNumber = thirdNumber;
            }

            firstNumber = highNumber;
            secondNumber = middleNumber;
            thirdNumber = lowNumber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}
