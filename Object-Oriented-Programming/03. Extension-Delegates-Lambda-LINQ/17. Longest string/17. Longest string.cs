namespace Longest_string
{
    using System;
    using System.Linq;
    class LongestString
    {
        static void Main() 
        {
            //Write a program to return the string with maximum length from an array of strings. - Task 17
            Console.WriteLine("String with maximum length from an array of strings. - Task 17\n");
            string[] someString = {
                "Lorem Ipsum is simply dummy text of the printing",
                " and typesetting industry. ",
                "Lorem Ipsum has been the ",
                "industry's standard dummy text ever since the 1500s, ",
                "when an unknown printer took a galley of type and scrambled it to make a ",
                "type specimen book. ",
                "It has survived not only five centuries, but also the"
            };
            var longestString = from str in someString
                                orderby str.Length descending
                                select str;
            Console.WriteLine("Longest string is:\n{0}", longestString.FirstOrDefault());
        }
    }
}
