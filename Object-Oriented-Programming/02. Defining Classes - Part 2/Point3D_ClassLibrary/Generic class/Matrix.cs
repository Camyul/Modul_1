

namespace Point3D_ClassLibrary.Generic_class
{
    using System;
    using System.Text;
    public class Matrix<T> where T : IComparable,      //Class Matrix<T> - Task 8
                              IComparable<T>,
                              IConvertible,
                              IEquatable<T>,
                              IFormattable
    {
        private T[,] matixArr;  // Field
        private int rows;
        private int cols;


        public Matrix(int row, int col)     //Constructor
        {
            this.Rows = row;
            this.Cols = col;
            matixArr = new T[this.Rows, this.Cols];
        }

        private int Rows      //Property 
        {
            get { return rows; }
            set
            {
                CheckIndexMatrixRange(value);
                this.rows = value;
            }
        }
        private int Cols          //Property 
        {
            get { return cols; }
            set
            {
                CheckIndexMatrixRange(value);
                this.cols = value;
            }
        }
        //public int GetRows()   // Return numbers of rows
        //{
        //    return this.Rows;
        //}
        public T this[int row, int col]            //Indexer - Task 9
        {
            get { return this.matixArr[row, col]; }
            set { this.matixArr[row, col] = value; }
        }
        public static Matrix<T> operator +(Matrix<T> firstArr, Matrix<T> secondArr)
        {
            if (firstArr.Rows != secondArr.Rows || firstArr.Cols != secondArr.Cols)
            {
                throw new InvalidOperationException("Invalid operation! Matrices must be of one and same size...");
            }
            Matrix<T> resultArr = new Matrix<T>(firstArr.rows, firstArr.cols);
            for (int i = 0; i < firstArr.Rows; i++)
            {
                for (int j = 0; j < firstArr.Cols; j++)
                {
                    resultArr[i, j] = (dynamic)firstArr[i, j] + (dynamic)secondArr[i, j];
                }
            }
            return resultArr;
        }
        public static Matrix<T> operator -(Matrix<T> firstArr, Matrix<T> secondArr)
        {
            if (firstArr.Rows != secondArr.Rows || firstArr.Cols != secondArr.Cols)
            {
                throw new InvalidOperationException("Invalid operation! Matrices must be of one and same size...");
            }
            Matrix<T> resultArr = new Matrix<T>(firstArr.Rows, firstArr.Cols);
            for (int i = 0; i < firstArr.Rows; i++)
            {
                for (int j = 0; j < firstArr.Cols; j++)
                {
                    resultArr[i, j] = (dynamic)firstArr[i, j] - (dynamic)secondArr[i, j];
                }
            }
            return resultArr;
        }
        public static Matrix<T> operator *(Matrix<T> firstArr, Matrix<T> secondArr)
        {
            if (firstArr.Rows != secondArr.Cols)
            {
                throw new InvalidOperationException("Invalid operation! Matrices must be of one and same size...");
            }
            Matrix<T> resultArr = new Matrix<T>(firstArr.Rows, secondArr.Cols);
            for (int i = 0; i < resultArr.Rows; i++)
            {
                for (int j = 0; j < resultArr.Cols; j++)
                {
                    for (int k = 0; k < firstArr.Cols; k++)
                    {
                        resultArr[i, j] += (dynamic)firstArr[i, k] * (dynamic)secondArr[k, j];
                    }
                }
            }
            return resultArr;
        }
        public static bool operator true(Matrix<T> matrix) // Implement the true operator (check for non-zero elements) - Task 10
        {
            bool isTrue = true;
            for (int i = 0; i < matrix.Rows && isTrue; i++)
            {
                for (int j = 0; j < matrix.Cols && isTrue; j++)
                {
                    if ((dynamic)matrix[i,j] == 0)
                    {
                        isTrue = false;
                    }
                }
            }
            return isTrue;
        }
        public static bool operator false(Matrix<T> matrix) // Implement the false operator (check for non-zero elements) - Task 10
        {
            bool isTrue = true;
            for (int i = 0; i < matrix.Rows && isTrue; i++)
            {
                for (int j = 0; j < matrix.Cols && isTrue; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        isTrue = false;
                    }
                }
            }
            return !isTrue;
        }
        public override string ToString()       //Override ToString() Method
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    sb.Append(matixArr[i, j]);
                    sb.Append(" ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
        private static void CheckIndexMatrixRange(int value)
        {
            if (value < 0 || value > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Index out of Range or Negative");
            }
        }
    }
}
