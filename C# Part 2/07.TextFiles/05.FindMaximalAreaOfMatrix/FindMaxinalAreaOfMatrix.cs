using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FindMaximalAreaOfMatrix
{
    class FindMaxinalAreaOfMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = PopulateMatrix();

            int maximalArea = GetTheMaximalArea(matrix);
            Console.WriteLine(maximalArea);
        }

        public static int[,] PopulateMatrix()
        {
            string[] lines;
            int n = 0;

            lines = GetNumbersFromFile(ref n);

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] ch = lines[i].Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Int32.Parse(ch[j]);
                }
            }
            return matrix;
        }

        private static string[] GetNumbersFromFile(ref int n)
        {
            string[] lines = null;
            string path = @"../../matrix.txt";
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    string line = reader.ReadLine();
                    n = Int32.Parse(line);
                    lines = new string[n];
                    for (int i = 0; i < n; i++)
                    {
                        lines[i] = reader.ReadLine();
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error while processing file: {0}", path);
            }

            return lines;
        }

        public static int GetTheMaximalArea(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = (matrix[row, col] + matrix[row + 1, col] +
                        matrix[row, col + 1] + matrix[row + 1, col + 1]);
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                }
            }

            return sum;
        }
    }
}
