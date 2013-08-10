using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareTwoTextFiles
{
    // This assume that the files are with the sam number of rows
    class CompareTwoTextFiles
    {
        static void Main(string[] args)
        {
            string path1 = @"../../firstFile.txt";
            string path2 = @"../../secondFile.txt";
            int differentLinesCount = 0;
            int sameLinesCount = 0;

            try
            {
                StreamReader reader1 = new StreamReader(path1);
                using (reader1)
                {
                    StreamReader reader2 = new StreamReader(path2);
                    using (reader2)
                    {
                        string firstFileLine = reader1.ReadLine();
                        string secondFileLine = reader2.ReadLine();
                        while (firstFileLine != null)
                        {
                            if (firstFileLine == secondFileLine)
                            {
                                sameLinesCount++;
                            }
                            else
                            {
                                differentLinesCount++;
                            }
                            firstFileLine = reader1.ReadLine();
                            secondFileLine = reader2.ReadLine();
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error occured while processing the files.");
            }

            Console.WriteLine("Same lines: {0}", sameLinesCount);
            Console.WriteLine("Different lines: {0}", differentLinesCount);
        }
    }
}
