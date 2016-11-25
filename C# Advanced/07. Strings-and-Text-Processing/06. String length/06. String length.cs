using System;

namespace String_length
{
    class StringLength
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine(str.PadRight(20, '*'));
        }
    }
}
