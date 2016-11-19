using System;
class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int[] nums = new int[numbers.Length];
        nums = ConvertArr(numbers, nums);
        int minElement = MinimalElement(nums);
        int maxElement = MaximalElement(nums);
        double average = AverageElements(nums);
        int sumElements = SumElements(nums);
        long prodElements = ProductElements(nums);
        Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}", 
            minElement, maxElement, average, sumElements, prodElements);
    }
    static long ProductElements(int[] nums)
    {
        long product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }
        return product;
    }
    static int SumElements(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }
    static double AverageElements(int[] nums)
    {
        double avrg = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            avrg += nums[i];
        }
        return avrg / nums.Length;
    }
    static int MaximalElement(int[] nums)
    {
        int max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (max < nums[i])
            {
                max = nums[i];
            }
        }
        return max;
    }
    static int MinimalElement(int[] nums)
    {
        int min = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }
        }
        return min;
    }
    static int[] ConvertArr(string[] strArr, int[] arr)
    {
        for (int i = 0; i < strArr.Length; i++)
        {
            arr[i] = int.Parse(strArr[i]);
        }
        return arr;
    }
}