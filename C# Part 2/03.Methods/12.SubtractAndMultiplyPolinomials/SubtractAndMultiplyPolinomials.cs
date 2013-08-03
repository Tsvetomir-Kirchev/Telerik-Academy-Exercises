using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SubtractAndMultiplyPolinomials
{
    class SubtractAndMultiplyPolinomials
    {
        static void Main()
        {
            Console.WriteLine("Enter in format: 32x6-28x2+18x-15 (example)\n");
            Console.Write("First polynomial: ");
            string firstPoly = Console.ReadLine();

            Console.Write("Second polynomial: ");
            string secondPoly = Console.ReadLine();

            int[] sum = AddTwoPolynomials(firstPoly, secondPoly);
            string result = TransformArrayToPoly(sum);

            int[] difference = SubtractPolynomials(firstPoly, secondPoly);
            string subtractionResult = TransformArrayToPoly(difference);

            int[] product = MultiplyTwoPolynomials(firstPoly, secondPoly);
            string productResult = TransformArrayToPoly(product);

            Console.WriteLine("\nAddition: {0}\n", result);
            Console.WriteLine("Subtraction: {0}\n", subtractionResult);
            Console.WriteLine("Multiply: {0}\n", productResult);
        }

        public static int[] ReturnArrayFromPolinom(string polynomial)
        {
            int number = 0;
            int lastIndex = 0;
            int position = 0;
            int[] array = new int[1000];
            int counter = 0;
            int signCounter = 0;

            polynomial = (polynomial[0] == '-' ? "" : "+") + polynomial;
            polynomial += (polynomial[polynomial.Length - 1] == 'x' ? "1" : "");

            for (int i = 0; i < polynomial.Length; i++)
            {
                if (polynomial[i] == 'x')
                {
                    counter++;
                }
                if (polynomial[i] == '+' || polynomial[i] == '-')
                {
                    signCounter++;
                }
            }

            if (counter < signCounter)
            {
                polynomial += "x0";
            }

            for (int i = 0; i < polynomial.Length; i++)
            {

                if (polynomial[i] == 'x')
                {
                    number = int.Parse(polynomial.Substring(lastIndex, i - lastIndex));
                    lastIndex = i + 1;
                }
                if ((polynomial[i] == '+' || polynomial[i] == '-') && i != 0)
                {
                    if (i - lastIndex == 0)
                    {
                        position = 1;
                    }
                    else
                    {
                        position = int.Parse(polynomial.Substring(lastIndex, i - lastIndex));
                    }
                    lastIndex = i;
                    array[position] = number;
                }
                if (i == polynomial.Length - 1)
                {
                    position = int.Parse(polynomial.Substring(lastIndex, polynomial.Length - lastIndex));
                    array[position] = number;
                }
            }
            return array;
        }

        public static int[] AddTwoPolynomials(string firstPoly, string secondPoly)
        {
            int[] firstArray = ReturnArrayFromPolinom(firstPoly);
            int[] secondArray = ReturnArrayFromPolinom(secondPoly);
            int[] sum = new int[firstArray.Length];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstArray[i] + secondArray[i];
            }
            return sum;
        }

        public static int[] SubtractPolynomials(string firstPolinomial, string secondPolinomial)
        {
            int[] firstArray = ReturnArrayFromPolinom(firstPolinomial);
            int[] secondArray = ReturnArrayFromPolinom(secondPolinomial);
            int[] difference = new int[firstArray.Length];

            for (int i = 0; i < difference.Length; i++)
            {
                difference[i] = firstArray[i] - secondArray[i];
            }
            return difference;
        }

        public static int[] MultiplyTwoPolynomials(string firstPoly, string secondPoly)
        {
            int[] firstArray = ReturnArrayFromPolinom(firstPoly);
            int[] secondArray = ReturnArrayFromPolinom(secondPoly);
            int[] product = new int[firstArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != 0)
                {
                    for (int j = 0; j < secondArray.Length; j++)
                    {
                        if (secondArray[j] != 0)
                        {
                            product[i + j] += firstArray[i] * secondArray[j];
                        }
                    }
                }
            }
            return product;
        }

        public static string TransformArrayToPoly(int[] array)
        {
            string result = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != 0)
                {
                    result += (array[i] >= 0 ? "+" : "") + array[i] + "x" + i;
                }
            }
            return result;
        }
    }
}
