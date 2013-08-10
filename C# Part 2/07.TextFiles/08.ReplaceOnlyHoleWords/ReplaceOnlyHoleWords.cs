using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.ReplaceOnlyHoleWords
{
    class ReplaceOnlyHoleWords
    {
        static void Main(string[] args)
        {
            string start = "start";
            string finish = "finish";
            string pattern = @"\b" + start + @"\b";

            string pathToRead = @"../../start.txt";
            string pathToWrite = @"../../finish.txt";

            try
            {
                StreamReader reader = new StreamReader(pathToRead);
                using (reader)
                {
                    StreamWriter writer = new StreamWriter(pathToWrite);
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            string result = Regex.Replace(line, pattern, finish);
                            writer.WriteLine(result);
                            line = reader.ReadLine();
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error while processing files.");
            }
        }
    }
}
