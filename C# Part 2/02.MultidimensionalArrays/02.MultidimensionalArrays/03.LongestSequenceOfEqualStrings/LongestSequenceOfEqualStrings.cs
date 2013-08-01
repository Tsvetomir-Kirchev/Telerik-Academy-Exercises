using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LongestSequenceOfEqualStrings
{
    class LongestSequenceOfEqualStrings
    {
        static void Main(string[] args)
        {
            string[,] matrix =
            {
                {"ha", "ha", "ha", "a"},
                {"h", "ha", "hi", "xx"},
                {"ha", "ho", "ha", "xx"}
            };

            //string[,] matrix =
            //{
            //    { "s",  "qq", "s" },
            //    { "pp", "pp", "s" },
            //    { "pp", "qq", "s" }
            //};

            FindMaximalSequenceOfEqualStrings(matrix);
        }

        private static void FindMaximalSequenceOfEqualStrings(string[,] matrix)
        {
            int biggerSequence = 0;
            int sum = 1;
            List<string> elemets = new List<string>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    for (int i = col; i < matrix.GetLength(1) - 1; i++)
                    {
                        if (matrix[col, i] == matrix[col, i + 1])
                        {
                            sum++;
                            if (sum > biggerSequence)
                            {
                                biggerSequence = sum;
                                elemets.Clear();
                                elemets.Add(matrix[row, i]);
                            }
                        }
                    }
                    sum = 1;

                    for (int i = row; i < matrix.GetLength(0) - 1; i++)
                    {
                        if (matrix[i, col] == matrix[i + 1, col])
                        {
                            sum++;
                            if (sum > biggerSequence)
                            {
                                biggerSequence = sum;
                                elemets.Clear();
                                elemets.Add(matrix[i, col]);
                            }
                        }
                    }
                    sum = 1;

                    for (int i = row, j = col; i < matrix.GetLength(0) - 1 &&
                        j < matrix.GetLength(1) - 1; i++, j++)
                    {
                        if (matrix[i, j] == matrix[i + 1, j + 1])
                        {
                            sum++;
                            if (sum > biggerSequence)
                            {
                                biggerSequence = sum;
                                elemets.Clear();
                                elemets.Add(matrix[row, i]);
                            }
                        }
                    }
                }
            }

            Print(biggerSequence, elemets);
        }

        private static void Print(int biggerSequence, List<string> elemets)
        {
            for (int i = 0; i < biggerSequence; i++)
            {
                if (i == biggerSequence - 1)
                {
                    Console.Write(elemets[0]);
                }
                else
                {
                    Console.Write(elemets[0] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
