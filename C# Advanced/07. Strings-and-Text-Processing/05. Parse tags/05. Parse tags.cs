using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_tags
{
    class ParseTags
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string startTag = "<upcase>";
            string endTag = "</upcase>";
            while (true)
            {
                int startIndex = text.IndexOf(startTag);
                if (startIndex == -1)
                {
                    break;
                }
                text = RemoveText(text, startIndex, startTag.Length);
                int endIndex = text.IndexOf(endTag);
                text = RemoveText(text, endIndex, endTag.Length);
                text = ConvertToUpper(text, startIndex, endIndex);
            }
            Console.WriteLine(text);
        }

        private static string RemoveText(string text, int index, int length)
        {
            text = text.Remove(index, length);
            return text;
        }

        private static string ConvertToUpper(string text, int startIndex, int endIndex)
        {
            string toUpper = text.Substring(startIndex, (endIndex - startIndex)).ToUpper();
            text = RemoveText(text, startIndex, toUpper.Length);
            text = text.Insert(startIndex, toUpper);
            return text;
        }
    }
}
