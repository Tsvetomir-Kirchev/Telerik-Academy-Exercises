using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ReplaceATagWithUrl
{
    class ReplaceATagWithUrl
    {
        static void Main(string[] args)
        {
            string inputHTML = "<html><head><title></title></head><body><p>Please visit <a href=\"http://academy.telerik.com\">" +
                "our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">" +
                "our forum</a> to discuss the courses.</p></body></html>";
            StringBuilder tag = new StringBuilder();
            StringBuilder outputHTML = new StringBuilder();
            bool inTag = false;
            foreach (var item in inputHTML)
            {
                if (item == '<')
                {
                    inTag = true;
                }
                if (item == '>')
                {
                    inTag = false;
                    tag.Append(item);
                    string temp = tag.ToString();
                    if (IsOpenATag(temp))
                    {
                        outputHTML.Append(ReplaceOpenATag(temp));
                    }
                    else if (IsClosedATag(temp))
                    {
                        outputHTML.Append(ReplaceClosedATag());
                    }
                    else
                    {
                        outputHTML.Append(temp);
                    }
                    tag.Clear();
                    continue;
                }
                if (inTag)
                {
                    tag.Append(item);
                }
                else
                {
                    outputHTML.Append(item);
                }
            }
            Console.WriteLine("Result: \r\n\"{0}\"", outputHTML.ToString());
        }
        static bool IsOpenATag(string currentTag)
        {
            string worckingStr = currentTag.Substring(0, 3);
            if (worckingStr.ToUpper() == "<a ".ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsClosedATag(string currentTag)
        {
            if (currentTag.ToUpper() == "</a>".ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string ReplaceOpenATag(string currentTag)
        {
            string workingStr = currentTag.ToUpper();
            int startIndex = workingStr.IndexOf("http:".ToUpper());
            int endIndex = workingStr.LastIndexOf("\"".ToUpper());
            string webAddress = String.Empty;
            if (startIndex > 0)
            {
                webAddress = currentTag.Substring(startIndex, endIndex - startIndex);
            }
            else
            {
                startIndex = workingStr.IndexOf("www.".ToUpper());
                if (startIndex > 0)
                {
                    webAddress = currentTag.Substring(startIndex, endIndex - startIndex);
                }
                else
                {
                    webAddress = "#";
                }
            }
            StringBuilder result = new StringBuilder("[URL=");
            result.Append(webAddress);
            result.Append("]");
            return result.ToString();
        }

        static string ReplaceClosedATag()
        {
            return "[/URL]";
        }
    }
}
