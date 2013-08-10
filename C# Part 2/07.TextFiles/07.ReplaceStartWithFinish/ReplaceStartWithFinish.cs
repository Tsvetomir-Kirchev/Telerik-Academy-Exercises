using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReplaceStartWithFinish
{
    class ReplaceStartWithFinish
    {
        static void Main(string[] args)
        {
            string start = "start";
            string finish = "finish";

            string pathToRead = @"../../start.txt";
            string pathToWrite = @"../../finish.txt";

            try
            {
                StreamReader reader = new StreamReader(pathToRead);
                using (reader)
                {
                    string line = reader.ReadLine();
                    StreamWriter writer = new StreamWriter(pathToWrite);
                    using (writer)
                    {
                        while (line != null)
                        {
                            writer.WriteLine(line.Replace(start, finish));
                            line = reader.ReadLine();
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error while processing the files");
            }
        }
    }
}
