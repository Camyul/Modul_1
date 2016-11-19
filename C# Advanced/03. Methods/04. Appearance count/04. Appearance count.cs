using System;
class Program
{
    
    static int CountNumAppears(string[] matrix, int count, string element)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            if (element == matrix[i])
            {
                count++;
            }
        }
        return count;
    }
   
    static void Main()
    {
        int size = Convert.ToInt32(Console.ReadLine());
        string[] matrix = Console.ReadLine().Split();
        string element = Console.ReadLine();
        int count = 0;
        count = CountNumAppears(matrix, count, element);
        
        Console.WriteLine(count);
    }
}