using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_URL
{
    class ParseURL
    {
        static void Main()
        {
            string url = Console.ReadLine();//@"http://telerikacademy.com/Courses/Courses/Details/212";
            string protocol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;
            protocol = ParseProtocolName(url);
            server = ParseServerName(url);
            resource = ParseResoursePath(url);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }

        private static string ParseResoursePath(string url)
        {
            string resource;
            int firstIndex = url.IndexOf("//") + 2;
            int secondIndex = url.IndexOf('/', firstIndex);
            resource = url.Substring(secondIndex);
            return resource;
        }

        private static string ParseServerName(string url)
        {
            string server;
            int startIndex = 0;
            startIndex = url.IndexOf("//") + 2;
            int endIndex = url.IndexOf('/', startIndex);
            server = url.Substring(startIndex, endIndex - startIndex);
            return server;
        }

        private static string ParseProtocolName(string url)
        {
            string protocol;
            int index = 0;
            index = url.IndexOf(':');
            protocol = url.Substring(0, index);
            return protocol;
        }
    }
}
