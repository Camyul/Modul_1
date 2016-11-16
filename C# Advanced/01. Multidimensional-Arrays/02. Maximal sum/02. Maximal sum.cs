using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string matrixSize = Console.ReadLine();
        string[] size = matrixSize.Split(' ');
        int row = int.Parse(size[0]);
        int col = int.Parse(size[1]);
        int maxSum = int.MinValue;
        int tempSum = 0;
        int[,] intNums = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            for (int j = 0; j < temp.Length; j++)
            {
                intNums[i, j] = int.Parse(temp[j]);
            }
        }
        for (int i = 0; i < intNums.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < intNums.GetLength(1) - 2; j++)
            {
                tempSum = 0;
                tempSum = TempSum(tempSum, intNums, i, j);
                if (maxSum < tempSum)
                {
                    maxSum = tempSum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }

    private static int TempSum(int tempSum, int[,] intNums, int i, int j)
    {
        for (int k = 0; k <= 2; k++)
        {
            for (int l = 0; l <= 2; l++)
            {
                tempSum += intNums[i + k, j + l];
            }
        }

        return tempSum;
    }
}