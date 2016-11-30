using System;
using System.Text;
using System.IO;

namespace _01.Odd_lines
{
    class OddLines
    {
      
        static void Main()
        {
            string pathToFile = @"../../oddLines.txt";
            string streamLine = "";
            StreamReader oddLine = new StreamReader(pathToFile, Encoding.UTF8);
            Console.OutputEncoding = Encoding.UTF8;
            using (oddLine)
            {
                
                int i = 0;
                while( streamLine != null)
                {
                    streamLine = oddLine.ReadLine();
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(streamLine);
                    }
                    i++;
                }
            }
        }
    }
}
