using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_sentence
{
    class ReverseRentence
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            string lastSymbol = sentence.Substring(sentence.Length - 1, 1);
            sentence = sentence.Remove(sentence.Length - 1);
            char comma = ',';
            List<int> indexComma = new List<int>();
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].IndexOf(comma) > 0)
                {
                    indexComma.Add(i);
                    words[i] = words[i].Remove(words[i].Length - 1);
                }
            }
            for (int i = 0; i < words.Length / 2; i++)
            {
                string temp = words[i];
                words[i] = words[words.Length - 1 - i];
                words[words.Length - 1 - i] = temp;
            }
            for (int i = 0; i < indexComma.Count; i++)
            {

                words[indexComma[i]] += comma;
            }
            
            Console.WriteLine(string.Join(" ", words) + lastSymbol);
        }
    }
}
