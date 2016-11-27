using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_tags_v2
{
    class ReplaceTagsV2
    {
        static void Main()
        {
            string textHTML = Console.ReadLine();   //@"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            int index = 0;
            int startTag = 0;
            int endTag = 0;
            string tag = string.Empty;
            while (true)
            {
                startTag = textHTML.IndexOf("<a", index + 1);
                if (startTag == -1)
                {
                    break;
                }
                endTag = textHTML.IndexOf("a>", index + 1);
                tag = textHTML.Substring(startTag, (endTag + 2 - startTag));
                textHTML = textHTML.Remove(startTag, (endTag + 2 - startTag));
                string siteName = GetSiteUrl(tag);
                textHTML = textHTML.Insert(startTag, siteName);
                string link = GetSiteLink(tag);
                textHTML = textHTML.Insert(startTag, link);

            }
            Console.WriteLine(textHTML);
        }

        private static string GetSiteLink(string tag)
        {
            StringBuilder linkedText = new StringBuilder();
            int startLink = 0;
            int endLink = 0;
            startLink = tag.IndexOf(">", 0);
            endLink = tag.IndexOf("<", startLink + 1);
            linkedText.Append("[");
            linkedText.Append(tag.Substring(startLink + 1, (endLink - 1 - startLink)));
            linkedText.Append("]");
            return linkedText.ToString();
        }

        private static string GetSiteUrl(string tag)
        {
            StringBuilder urlAdress = new StringBuilder();
            int startUrl = 0;
            int endUrl = 0;
            startUrl = tag.IndexOf("\"", 0);
            endUrl = tag.IndexOf("\"", startUrl + 1);
            urlAdress.Append("(");
            urlAdress.Append(tag.Substring(startUrl + 1, (endUrl - 1 - startUrl)));
            urlAdress.Append(")");
            return urlAdress.ToString();
        }
    }
}
