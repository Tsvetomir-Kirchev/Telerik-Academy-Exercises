using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FindEqualNeghtborElements
{
    class FindEqualNeightborElements
    {
        private static int[,] matrix;
        private static int[,] visitedElementsArray;
        private static int currentElementsCount = 0;

        static void Main()
        {
            matrix = new int[,]
            {
                { 1, 3, 2, 2, 2, 4 },
                { 3, 3, 3, 2, 4, 4 },
                { 4, 3, 2, 1, 3, 3 },
                { 4, 3, 1, 3, 3, 1 },
                { 4, 3, 3, 3, 1, 1 }
            };
            visitedElementsArray = new int[matrix.GetLength(0), matrix.GetLength(1)];

            int longestNeighbourElementsCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentNumberOfNeighbourElements = FindNumberOfEqualNeighbourElements(row, col, true, -1);

                    if (currentNumberOfNeighbourElements > longestNeighbourElementsCount)
                    {
                        longestNeighbourElementsCount = currentNumberOfNeighbourElements;
                    }
                }
            }

            Console.WriteLine(longestNeighbourElementsCount);
        }

        public static int FindNumberOfEqualNeighbourElements(int row, int col, bool atOrigin, int previousNumber)
        {
            if (atOrigin)
            {
                currentElementsCount = 0;
            }

            if (row == matrix.GetLength(0) ||
                col == matrix.GetLength(1) ||
                row < 0 || col < 0)
            {
                return 0;
            }
            else if (visitedElementsArray[row, col] != 0)
            {
                return 0;
            }

            int currentNumberAtPosition = matrix[row, col];
            if (currentNumberAtPosition == previousNumber || atOrigin)
            {
                visitedElementsArray[row, col] = 1;
                currentElementsCount++;

                FindNumberOfEqualNeighbourElements(row + 1, col, false, currentNumberAtPosition);
                FindNumberOfEqualNeighbourElements(row - 1, col, false, currentNumberAtPosition);
                FindNumberOfEqualNeighbourElements(row, col - 1, false, currentNumberAtPosition);
                FindNumberOfEqualNeighbourElements(row, col + 1, false, currentNumberAtPosition);
            }
            else
            {
                return 0;
            }

            return currentElementsCount;
        }

    }
}
