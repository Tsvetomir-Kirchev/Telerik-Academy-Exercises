using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare2CharArraysLexicographivally
{
    class Compare2CharArraysLexicographivally
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the arrays: ");
            int arraysLength = Int32.Parse(Console.ReadLine());

            char[] firstArray = new char[arraysLength];
            char[] secondArray = new char[arraysLength];

            Console.WriteLine("Enter the characters of firstArray: ");
            ReadArrayFromConsole(firstArray);

            Console.WriteLine("Enter the characters of secondArray: ");
            ReadArrayFromConsole(secondArray);

            CompareArrays(arraysLength, firstArray, secondArray);
        }

        private static void CompareArrays(int arraysLength, char[] firstArray, char[] secondArray)
        {
            for (int index = 0; index < arraysLength; index++)
            {
                int compare = firstArray[index].CompareTo(secondArray[index]);

                if (compare < 0)
                {
                    Console.WriteLine("{0} > {1}", firstArray[index], secondArray[index]);
                }
                else if (compare > 0)
                {
                    Console.WriteLine("{0} < {1}", firstArray[index], secondArray[index]);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", firstArray[index], secondArray[index]);
                }
            }
        }

        private static void ReadArrayFromConsole(char[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write("firstArray[{0}] = ", index);
                arr[index] = Char.Parse(Console.ReadLine());
            }
        }
    }
}
