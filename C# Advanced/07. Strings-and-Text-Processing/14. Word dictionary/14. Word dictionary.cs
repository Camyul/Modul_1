using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_dictionary
{
    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            Console.Write("Please insert a word(\".NET\", \"CLR\", \"namespace\"): ");
            string word = Console.ReadLine();
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("{0} is: {1}", word, dictionary[word]);
            }
            else
            {
                Console.WriteLine("Dictionary don't contain this word!");
            }
                        
        }
    }
}
