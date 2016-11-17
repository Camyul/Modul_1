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
        int count = 1;
        int maxCount = 1;
        string[,] matrixNums = new string[row, col];
        for (int i = 0; i < row; i++)
        {
            string[] tempStr = Console.ReadLine().Split(' ');
            for (int j = 0; j < tempStr.Length; j++)
            {
                matrixNums[i, j] = tempStr[j];
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col -1; j++)
            {
                if ((matrixNums[i, j] == matrixNums[i, j + 1]))
                {

                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
        for (int j = 0; j < col; j++)
        {
            for (int i = 0; i < row - 1; i++)
            {
                if (matrixNums[i, j] == matrixNums[i +1, j])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
        int k = matrixNums.GetLength(0) -1;
        int l = 0;
        while (!((k == 0) && (l == matrixNums.GetLength(1) -1)))
        {
            int step = 0;
            
            if (k > 0)
            {
                k--;
            }
            else
            {
                l++;
            }
            while ((k + step < matrixNums.GetLength(0) -1) && (l + step < matrixNums.GetLength(1) -1))
            {
                if (matrixNums[k + step, l + step] == matrixNums[k + step + 1, l + step + 1])
                {
                    count++;
                    step++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                    step++;
                }
            }
        }
        k = matrixNums.GetLength(0) - 1;
        l = matrixNums.GetLength(1) - 1;
        while (!((k == 0) && (l == 0)))
        {
            int step = 0;

            if (k > 0)
            {
                k--;
            }
            else
            {
                l--;
            }
            while ((k + step < matrixNums.GetLength(0) - 1) && (l - step > 0))
            {
                if (matrixNums[k + step, l - step] == matrixNums[k + step + 1, l - step - 1])
                {
                    count++;
                    step++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                    step++;
                }
            }
        }
        Console.WriteLine(maxCount);
    }
}