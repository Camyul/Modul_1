using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static int BinSearch(int[] arr,int maxIndex,int minIndex, int k)
    {
       
        int tempIndex = (maxIndex - minIndex) / 2;
        while ((arr[maxIndex] <= k) && (arr[maxIndex - 1] > k))
        {
            if (k < arr[tempIndex])
            {
                maxIndex = tempIndex;
            }
            else if (k >= arr[tempIndex])
            {
                minIndex = tempIndex;
            }
        }
        return maxIndex;
    }
    static void Main()
    {
        string[] strArr = Console.ReadLine().Split(' ');
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[strArr.Length];
        int maxIndex = arr.Length - 1;
        int minIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(strArr[i]);
        }
        Array.Sort(arr);
        maxIndex = BinSearch(arr, maxIndex, minIndex, k);
        Console.WriteLine(maxIndex);
    }
}