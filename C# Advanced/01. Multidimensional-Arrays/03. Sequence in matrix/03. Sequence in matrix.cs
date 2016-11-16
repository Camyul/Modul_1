using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string[] matrixSize = Console.ReadLine().Split(' ');
        int row = int.Parse(matrixSize[0]);
        int col = int.Parse(matrixSize[1]);
        int count = 0;
        int[,] matrixNums = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            string[] tempStr = Console.ReadLine().Split(' ');
            for (int j = 0; j < tempStr.Length; j++)
            {
                matrixNums[i, j] = int.Parse(tempStr[j]);
            }
        }
        Console.WriteLine(count);
    }
}