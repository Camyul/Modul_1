

namespace StringBuilder.Substring
{
    using System;
    using System.Text;
    class StringBuilderSubstring
    {
        static void Main()
        {
            StringBuilder strBuilder =  new StringBuilder();
            strBuilder.Append("I am a String Builder");
            StringBuilder firstStrBuilder =  strBuilder.Substring(0, 6);
            StringBuilder secondStrBuilder =  strBuilder.Substring(7);
            Console.WriteLine(firstStrBuilder.ToString());
            Console.WriteLine(secondStrBuilder.ToString());
        }
    }
}
