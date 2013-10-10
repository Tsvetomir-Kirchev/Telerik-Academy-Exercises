using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix1 = new Matrix<int>(5, 5);
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    matrix1[i, j] = i * j;
                }
            }

            Matrix<int> matrix2 = new Matrix<int>(5, 5);
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    matrix2[i, j] = i * j;
                }
            }

            int el = matrix1[2, 2];
            Console.WriteLine("matrix1[2, 2]: {0}", el);
            Console.WriteLine("matrix1:");
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine("matrix2: ");
            Console.WriteLine(matrix2.ToString());

            Matrix<int> matrixMultiplied = new Matrix<int>(5, 5);
            matrixMultiplied = matrix1 * matrix2;
            Console.WriteLine("matrix1 * matrix2:");
            Console.WriteLine(matrixMultiplied.ToString());

            Matrix<int> matrixAddition = new Matrix<int>(5, 5);
            matrixAddition = matrix1 + matrix2;
            Console.WriteLine("matrix1 + matrix2:");
            Console.WriteLine(matrixAddition.ToString());

            Matrix<int> matrixSubtract = new Matrix<int>(5, 5);
            matrixAddition = matrix1 + matrix2;
            Console.WriteLine("matrix1 - matrix2:");
            Console.WriteLine(matrixSubtract.ToString());

            Matrix<int> m = new Matrix<int>(2, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m[i, j] = 1;
                }
            }
            if (m)
            {
                Console.WriteLine("m have no element with value 0");
            }
        }
    }
}
