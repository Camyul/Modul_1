using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int size = Convert.ToInt32(Console.ReadLine());
        string symbol = Console.ReadLine();
        int[,] matrix = new int[size, size];
        int count = 1;
        if (symbol == "a")
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, j] = count;
                    count++;
                }
            }
        }
        else if (symbol == "b")
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, j] = count;
                        count++;
                    }
                }
                else
                {
                    for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                    {
                        matrix[i, j] = count;
                        count++;
                    }
                }
            }
        }
        else if (symbol == "c")
        {
            int j = 0;
            int i = matrix.GetLength(0) - 1;
            matrix[i, j] = count++;
            while (count <= size * size)
            {
                int k = 0;
                if (i > 0)
                {
                    i--;
                }
                else if (i == 0)
                {
                    j++;
                }
                while ((j + k < size) && (i + k < size))
                {
                    matrix[i+k, j+k] = count++;
                    k++;
                }
                

            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.Write(matrix[i, j]);
                }
                else
                {
                    Console.Write(" {0}", matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}