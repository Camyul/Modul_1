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


        public Matrix(int rows, int cols)     //Constructor
        {
            this.Rows = rows;
            this.Cols = cols;
            matixArr = new T[this.Rows, this.Cols];
        }

        public int Rows { get; set; }       //Property
        public int Cols { get; set; }

        public T this[int rows, int cols]            //Indexer - Task 9
        {
            get { return matixArr[this.Rows, this.Cols]; }
            set { this.matixArr[rows, cols] = value; }
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
    }
}
