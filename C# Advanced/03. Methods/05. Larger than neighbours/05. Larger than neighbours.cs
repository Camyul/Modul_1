using System;
class Program
{
    static int Larger(int[] arr, int i)
    {
        if ((i > 0 && i < arr.Length -1) && 
           ((arr[i] > arr[i-1]) && (arr[i] > arr[i + 1])))
        {
            return 1;
        }
        else
        {
            return 0;
        }

    }
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string[] stringMatrix = Console.ReadLine().Split();
        int count = 0;
        int[] matrix = new int[size];
        for (int i = 0; i < size; i++)
        {
            matrix[i] = int.Parse(stringMatrix[i]);
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            count += Larger(matrix, i);
        }
        Console.WriteLine(count);
    }
}