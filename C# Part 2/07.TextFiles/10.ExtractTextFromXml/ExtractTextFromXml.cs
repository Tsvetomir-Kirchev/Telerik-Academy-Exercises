using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractTextFromXml
{
    class ExtractTextFromXml
    {
        static void Main(string[] args)
        {
            bool inTag = false;
            string xml = null;
            string path = @"../../xml.txt";

            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    xml = reader.ReadToEnd();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error while processing file: {0}", path);
            }

            StringBuilder cleanText = ExtractText(ref inTag, xml);
            Console.WriteLine(cleanText.ToString());
        }

        private static StringBuilder ExtractText(ref bool inTag, string xml)
        {
            StringBuilder cleanText = new StringBuilder();
            for (int i = 0; i < xml.Length; i++)
            {
                if (xml[i] == '<')
                {
                    inTag = true;
                    continue;
                }
                if (xml[i] == '>')
                {
                    inTag = false;
                    continue;
                }

                if (inTag)
                {
                    continue;
                }
                else
                {
                    cleanText.Append(xml[i]);
                }
            }
            return cleanText;
        }
    }
}
