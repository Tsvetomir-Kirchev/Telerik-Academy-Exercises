using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Matrix
{
    public class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row >= rows || row < 0) || (col >= cols || col < 0))
                {
                    throw new IndexOutOfRangeException();
                }
                return matrix[col, row];
            }
            set
            {
                if ((row >= rows || row < 0) || (col >= cols || col < 0))
                {
                    throw new IndexOutOfRangeException();
                }
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if ((matrix1.rows != matrix2.rows) || (matrix2.cols != matrix1.cols))
            {
                throw new ArgumentException("The matricies are not equal");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.rows, matrix1.cols);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.cols; j++)
                {
                    dynamic m1 = matrix1[i, j];
                    dynamic m2 = matrix2[i, j];
                    resultMatrix[i, j] = m1 + m2;
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if ((matrix1.rows != matrix2.rows) || (matrix2.cols != matrix1.cols))
            {
                throw new ArgumentException("The matricies are not equal");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.rows, matrix1.cols);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.cols; j++)
                {
                    dynamic m1 = matrix1[i, j];
                    dynamic m2 = matrix2[i, j];
                    resultMatrix[i, j] = m1 - m2;
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.cols != matrix2.rows)
            {
                throw new ArgumentException("The cols of first matrix and rows of second matrix are not equal");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.cols, matrix1.rows);
            for (int i = 0; i < matrix1.cols; i++)
            {
                for (int j = 0; j < matrix2.rows; j++)
                {
                    dynamic m1 = matrix1[i, j];
                    dynamic m2 = matrix2[j, i];
                    resultMatrix[i, j] = m1 * m2;
                }
            }
            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool result = true;
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool result = false;
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
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
