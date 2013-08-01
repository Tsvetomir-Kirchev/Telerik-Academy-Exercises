using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Matrix
{
    class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int cols;

        public int GetRowsLength
        {
            get { return this.rows; }
        }

        public int GetColsLength
        {
            get { return this.cols; }
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new int[this.rows, this.cols];
        }

        public void SetMatrixElement(int row, int col, int value)
        {
            matrix[row, col] = value;
        }

        public int GetMatrixElement(int row, int col)
        {
            return matrix[row, col];
        }

        static void Main(string[] args)
        {
            Matrix firstMatrix = new Matrix(2, 2);
            Matrix secondMatrix = new Matrix(2, 2);

            InitializeMatrix(firstMatrix);
            InitializeMatrix(secondMatrix);

            Matrix resultMatrix = firstMatrix + secondMatrix;
            Console.WriteLine(resultMatrix.ToString());

            resultMatrix = firstMatrix * secondMatrix;

            Console.WriteLine(resultMatrix.ToString());
        }

        private static Matrix InitializeMatrix(Matrix matrix)
        {
            for (int row = 0; row < matrix.GetRowsLength; row++)
            {
                for (int col = 0; col < matrix.GetColsLength; col++)
                {
                    Console.Write("matrix[{0}][{1}] = ", row, col);
                    int value = Int32.Parse(Console.ReadLine());
                    matrix.SetMatrixElement(row, col, value);
                }
            }
            return matrix;
        }

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix resultMatrix = new Matrix(firstMatrix.GetRowsLength,
                firstMatrix.GetColsLength);
            for (int row = 0; row < firstMatrix.GetRowsLength; row++)
            {
                for (int col = 0; col < firstMatrix.GetColsLength; col++)
                {
                    int value = firstMatrix.GetMatrixElement(row, col) +
                        secondMatrix.GetMatrixElement(row, col);
                    resultMatrix.SetMatrixElement(row, col, value);
                }
            }
            return resultMatrix;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix resultMatrix = new Matrix(firstMatrix.GetRowsLength,
                firstMatrix.GetColsLength);
            for (int row = 0; row < firstMatrix.GetRowsLength; row++)
            {
                for (int col = 0; col < firstMatrix.GetColsLength; col++)
                {
                    int value = firstMatrix.GetMatrixElement(row, col) *
                        secondMatrix.GetMatrixElement(row, col);
                    resultMatrix.SetMatrixElement(row, col, value);
                }
            }
            return resultMatrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sb.Append(matrix[row, col]);
                    sb.Append("    ");
                }
                sb.AppendLine();
            }
            return (sb.ToString());
        }
    }
}
