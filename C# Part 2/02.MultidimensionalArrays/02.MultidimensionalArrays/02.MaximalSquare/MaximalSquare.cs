using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSquare
{
    class MaximalSquare
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];

            FillMatrix(matrix);
            FindSquareWithBestSum(matrix);
        }

        private static void FindSquareWithBestSum(int[,] matrix)
        {
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] +
                            matrix[row, col + 2] + matrix[row + 1, col + 2] +
                            matrix[row + 2, col + 2] + matrix[row + 2, col + 1] +
                            matrix[row + 2, col];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            PrintBestSquare(bestRow, bestCol, matrix);
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    matrix[row, col] = Int32.Parse(Console.ReadLine());
                }
            }
        }

        private static void PrintBestSquare(int bestRow, int bestCol, int[,] matrix)
        {
            Console.WriteLine("The best square is: ");
            for (int row = bestRow; row < bestRow + 2; row++)
            {
                for (int col = bestCol; col < bestCol + 2; col++)
                {
                    Console.Write(" {0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
