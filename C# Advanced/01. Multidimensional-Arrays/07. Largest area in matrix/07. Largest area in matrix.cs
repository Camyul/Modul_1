using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int row;
    static int col;
    static int[,] matrixNums;
    static int maxCount = 0;
    static int count = 0;
    static bool[,] visitedElement;
    static void Main()
    {

        string[] matrixSize = Console.ReadLine().Split();
        row = int.Parse(matrixSize[0]);
        col = int.Parse(matrixSize[1]);
        matrixNums = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            string[] temp = Console.ReadLine().Split();
            for (int j = 0; j < temp.Length; j++)
            {
                matrixNums[i, j] = int.Parse(temp[j]);
            }
        }
        visitedElement = new bool[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                visitedElement[i, j] = false;
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                int element = matrixNums[i, j];
                DFSRecursive(element, i, j, ref count);
                if (maxCount < count)
                {
                    maxCount = count;
                }
                count = 0;
            }
        }
        Console.WriteLine(maxCount);
    }

    static void DFSRecursive(int element, int i,int j,ref int count)
    {
        if (i < 0 || j < 0 || i >= row || j >= col || visitedElement[i, j] == true)
        {
            return;
        }
        if (element == matrixNums[i, j])
        {
            count++;
            visitedElement[i, j] = true;
        }
        DFSRecursive(element, (i + 1), j, ref count);
        DFSRecursive(element, i, (j + 1), ref count);
        DFSRecursive(element, i, (j - 1), ref count);
        DFSRecursive(element, (i - 1), j, ref count);
    }
}