using System;

class ReplaceTagsV3
{
    static void Main()
    {
        string textHTML = Console.ReadLine();
        string[] separators = { "<a href=\"", "</a>" };
        string[] splitedHTML = textHTML.Split(separators, StringSplitOptions.None);
        for (int i = 1; i < splitedHTML.Length; i += 2)
        {
            int index = splitedHTML[i].IndexOf("\">");
            string url = splitedHTML[i].Substring(0, index);
            string linkText = splitedHTML[i].Substring(index + 2, splitedHTML[i].Length - index - 2);
            splitedHTML[i] = "[" + linkText + "]" + "(" + url + ")";
        }
        Console.WriteLine(string.Join(string.Empty, splitedHTML));
    }
}


//string input = Console.ReadLine();
//string[] splitted = input.Split(new[] { "<a href=\"", "</a>" }, StringSplitOptions.None);
//        for (int i = 1; i<splitted.Length; i += 2)
//        {
//            int index = splitted[i].IndexOf("\">");
//string URL = splitted[i].Substring(0, index);
//string TEXT = splitted[i].Substring(index + 2, splitted[i].Length - index - 2);
//splitted[i] = "[" + TEXT + "]" + "(" + URL + ")";
//        }
//        Console.WriteLine(string.Join(string.Empty, splitted));