using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillAndPrintMatrix
{
    class FillAndPrintMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            Console.WriteLine("a)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            matrix = FillMatrixUpToDown(matrix);
            PrintMatrix(matrix);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("b)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            matrix = FillMatrixUpToDownAndUp(matrix);
            PrintMatrix(matrix);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("c)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            matrix = FillMatrixDiagonal(matrix);
            PrintMatrix(matrix);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("d)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            matrix = FillMatrixSpiral(matrix);
            PrintMatrix(matrix);

        }

        private static int[,] FillMatrixSpiral(int[,] matrix)
        {
            int i = matrix.GetLength(0);
            int j = matrix.GetLength(0);
            int maxRow = i - 1;
            int minRow = 0;
            int maxCol = j - 1;
            int minCol = 0;
            int l = minCol;
            int k = minRow;
            int num = 0;

            while (num != i * j)
            {
                for (k = minRow; k <= maxRow; k++)
                {
                    num++;
                    matrix[k, l] = num;
                }
                k = maxRow;
                minCol++;

                for (l = minCol; l <= maxCol; l++)
                {
                    num++;
                    matrix[k, l] = num;
                }
                maxRow--;
                l = maxCol;

                for (k = maxRow; k >= minRow; k--)
                {
                    num++;
                    matrix[k, l] = num;
                }
                maxCol--;
                k = minRow;

                for (l = maxCol; l >= minCol; l--)
                {
                    num++;
                    matrix[k, l] = num;
                }
                minRow++;
                l = minCol;
            }
            return matrix;
        }

        private static int[,] FillMatrixDiagonal(int[,] matrix)
        {
            int counter = 1;
            int length = matrix.GetLength(0);
            matrix[length - 1, 0] = counter;
            matrix[0, length - 1] = length * length;
            counter++;
            for (int index = length - 2; index >= 0; index--)
            {
                for (int row = 0; row <= length - 1; row++)
                {
                    for (int col = length - 1; col >= 0; col--)
                    {
                        if (row == col)
                        {
                            if (row - index < 0)
                            {
                                continue;
                            }
                            else
                            {
                                matrix[col, row - index] = counter;
                                counter++;
                            }

                        }
                    }
                }
            }
            counter = (length * length) - 1;
            for (int index = length - 2; index > 0; index--)
            {
                for (int col = length - 1; col > 0; col--)
                {
                    for (int row = 0; row <= length - 1; row++)
                    {
                        if (row == col)
                        {
                            if (col - index < 0)
                            {
                                continue;
                            }
                            else
                            {
                                matrix[col - index, row] = counter;
                                counter--;
                            }
                        }
                    }
                }
            }
            return matrix;
        }

        private static int[,] FillMatrixUpToDown(int[,] matrix)
        {
            int value = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = value;
                    value++;
                }
            }
            return matrix;
        }

        private static int[,] FillMatrixUpToDownAndUp(int[,] matrix)
        {
            int value = 1;
            int length = matrix.GetLength(0) - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[col, row] = value;
                        value++;
                    }
                    else
                    {
                        matrix[length, row] = value;
                        value++;
                        length--;
                    }
                }
                length = matrix.GetLength(0) - 1;
            }
            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}\t", matrix[row, col]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
