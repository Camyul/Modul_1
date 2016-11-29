using System;
using System.IO;
using System.Net;

namespace Download_file
{
    class DownloadFile
    {
        static void Main()
        {
            try
            {
                string webAdress = Console.ReadLine();
                WebClient client = new WebClient();
                client.DownloadFile(webAdress, @"d:\news-img01.png");// second argument is path to save file
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format");

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
            }
            catch (IOException)
            {
                Console.WriteLine("error occurred while opening the file.");
            }
            catch (WebException)
            {
                Console.WriteLine("Wrong Address");
            }
           
        }
    }
}
