using System;
class Program
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        string name = Console.ReadLine();
        PrintName(name);
    }
}