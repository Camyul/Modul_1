using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D_ClassLibrary.Generic_class
{
    public class Matrix<T> where T : IComparable,      //Class Matrix<T> - Task 8
                              IComparable<T>,
                              IConvertible,
                              IEquatable<T>,
                              IFormattable
    {
        private T[,] matixArr;  // Field
        private  int rows;
        private  int cols;


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
            get { return matixArr[this.Rows, this.Cols]; }
            set { this.matixArr[row, col] = value; }
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
