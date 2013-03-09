using System;
using System.Text;

namespace Matrix
{
    class Matrix<T> where T : IComparable, IComparable<T>
    {

        private readonly T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = new T[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    this.matrix[i, j] = matrix[i, j];
                }
            }
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Columns
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public T this[int row, int column]
        {
            get
            {
                if (row >= matrix.GetLength(0) || row < 0 || column >= matrix.GetLength(1) || column < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.matrix[row, column];
            }
            set
            {
                if (row >= matrix.GetLength(0) || row < 0 || column >= matrix.GetLength(1) || column < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                this.matrix[row, column] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArithmeticException("The matrices are with different size!");
            }
            Matrix<T> sum = new Matrix<T>(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    sum[i, j] = (T)( (dynamic)a[i, j] + (dynamic)b[i, j]);
                }
            }
            return sum;
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArithmeticException("The matrices are with different size!");
            }
            Matrix<T> sub = new Matrix<T>(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    sub[i, j] = (T)((dynamic)a[i, j] - (dynamic)b[i, j]);
                }
            }
            return sub;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Columns != b.Rows)
            {
                throw new ArithmeticException("The matrices are with different size!");
            }
            else
            {
                Matrix<T> mult = new Matrix<T>(a.Rows, b.Columns);

                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < b.Columns; j++)
                    {
                        dynamic sum = 0;
                        for (int x = 0; x < a.Columns; x++)
                        {
                            sum = sum + (T)((dynamic)a[i, x] * (dynamic)b[x, j]);
                        }
                        mult[i, j] = sum;
                    }
                }

                return mult;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (matrix[i, j].CompareTo(default(T)) != 0) // default for numbers is 0
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix == null || matrix.Rows == 0 || matrix.Columns == 0)
            {
                return true;
            }

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (matrix[i, j].CompareTo(default(T)) != 0) // default for numbers is 0
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
