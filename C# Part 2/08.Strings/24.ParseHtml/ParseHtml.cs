using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.ParseHtml
{
    class ParseHtml
    {
        static void Main(string[] args)
        {
            string inputLine = "<html><head><title>News</title></head><body><p><a href=" +
                "\"http://academy.telerik.com\">Telerikn Academy</a>aims to provide free real-world practical" +
                " training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            bool betweenTagBrackets = false;
            StringBuilder text = new StringBuilder();
            StringBuilder tag = new StringBuilder();
            string title = string.Empty;
            foreach (char symbol in inputLine)
            {
                if (symbol == '<')
                {
                    betweenTagBrackets = true;
                }
                if (symbol == '>')
                {
                    betweenTagBrackets = false;
                    tag.Append(symbol);
                    if (tag.ToString().ToUpper() == "</title>".ToUpper())
                    {
                        title = text.ToString();
                        text.Clear();
                    }
                    if (tag.ToString().ToUpper() == "</a>".ToUpper())
                    {
                        text.Append(" ");
                    }
                    tag.Clear();
                    continue;
                }
                if (betweenTagBrackets == false)
                {
                    text.Append(symbol);
                }
                else
                {
                    tag.Append(symbol);
                }
            }
            Console.WriteLine("Title of the HTML is: {0}", title);
            Console.WriteLine("{0}", text.ToString());
        }
    }
}
