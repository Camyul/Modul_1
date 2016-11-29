using System;
using System.Security;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_file_contents
{
    class ReadFileContents
    {
        static void Main()
        {
            try
            {
                string content = File.ReadAllText(Console.ReadLine());
                Console.WriteLine(content);
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
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
            }
            catch (IOException)
            {
                Console.WriteLine("error occurred while opening the file.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("path is null.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("path is a zero-length string, contains only white space, or contains one or more invalid characters");
            }
            
        }
    }
}
