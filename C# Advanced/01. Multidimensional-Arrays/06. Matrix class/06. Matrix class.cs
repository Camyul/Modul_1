using System;
using Matrix_namespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_class
{   
    class MatrixClass
    {
        static void Main()
        {
            Matrix firstMatrix = new Matrix(3, 1);
            Matrix secondMatrix = new Matrix(2, 1);
            Matrix thirdMatrix = firstMatrix * secondMatrix;
            Console.WriteLine("New Matrix Rows: {0}", thirdMatrix.Rows);
            Console.WriteLine("New Matrix Cols: {0}", thirdMatrix.Cols);
            Console.WriteLine("New Matrix Lenght: {0}", thirdMatrix.MatrLenght);

        }
    }
}
