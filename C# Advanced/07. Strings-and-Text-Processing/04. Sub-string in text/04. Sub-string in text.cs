namespace Sub_string_in_text
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int index = 0;
            int count = 0;
            do
            {
                index = text.IndexOf(pattern, index + 1);
                if (index != -1)
                {
                    count++;
                }

            } while (index != -1);
            Console.WriteLine(count);
        }
    }
}

//namespace Sub_string_in_text
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using System.Threading.Tasks;
//    class Program
//    {
//        static void Main()
//        {
//            string pattern = Console.ReadLine().ToLower();
//            string text = Console.ReadLine().ToLower();
//            int count = 0;
//            for (int i = 0; i < (text.Length - pattern.Length + 1); i++)
//            {
//                if (text.Substring(i, pattern.Length) == pattern)
//                {
//                    count++;
//                }

//            }
//            Console.WriteLine(count);
//        }
//    }
//}
