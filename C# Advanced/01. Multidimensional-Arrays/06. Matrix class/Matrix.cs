using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Matrix_namespace
{

    class Matrix
    {
        public int MatrLenght {
            get
            {
               
                int lenght = ++Cols * ++Rows;
                return lenght;
            }
                }
        public int Cols { get; set; }
        public int Rows { get; set; }
        public Matrix()
        {
            Rows = 0;
            Cols = 0;
        }
        public Matrix(int cols)
        {
            Rows = 0;
            Cols = cols;
        }
        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix mNew = new Matrix();
            mNew.Rows = m1.Rows + m2.Rows;
            mNew.Cols = m1.Cols + m2.Cols;
            return mNew;
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix mNew = new Matrix();
            mNew.Rows = m1.Rows - m2.Rows;
            mNew.Cols = m1.Cols - m2.Cols;
            if (mNew.Rows < 0 || mNew.Cols < 0)
            {
                throw new ArgumentException(String.Format("First Matrix can't be smaller\n"));
            }
            
            
            return mNew;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix mNew = new Matrix();
            mNew.Rows = m1.Rows * m2.Rows;
            mNew.Cols = m1.Cols * m2.Cols;
            return mNew;
        }
    }
}
