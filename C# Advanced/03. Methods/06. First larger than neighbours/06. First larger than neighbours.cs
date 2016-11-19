using System;
class Program
{
    static int Larger(int[] arr, int i)
    {
        if ((i > 0 && i < arr.Length - 1) &&
           ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1])))
        {
            return i;
        }
        else
        {
            return -1;
        }

    }
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string[] stringMatrix = Console.ReadLine().Split();
        int index = -1;
        int[] matrix = new int[size];
        for (int i = 0; i < size; i++)
        {
            matrix[i] = int.Parse(stringMatrix[i]);
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            index = Larger(matrix, i);
            if (index > -1)
            {
                break;
            }
        }
        Console.WriteLine(index);
    }
}