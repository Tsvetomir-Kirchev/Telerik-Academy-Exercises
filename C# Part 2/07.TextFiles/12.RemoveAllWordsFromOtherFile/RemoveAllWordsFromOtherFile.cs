using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RemoveAllWordsFromOtherFile
{
    class RemoveAllWordsFromOtherFile
    {
        static void Main(string[] args)
        {
            string[] words = null; ;
            string path = @"../../words.txt";
            StreamReader reader;
            try
            {
                reader = new StreamReader(path);
                using (reader)
                {
                    string allText = reader.ReadToEnd();
                    words = allText.Split(' ');
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Cannot find file: {0}", path);
            }
            catch (IOException)
            {
                Console.WriteLine("Error while processing file: {0}", path);
            }

            path = @"../../text.txt";
            try
            {
                reader = new StreamReader(path);
                using (reader)
                {
                    string output = @"../../output.txt";
                    StreamWriter writer = new StreamWriter(output);
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            for (int i = 0; i < words.Length; i++)
                            {
                                line = line.Replace(words[i], "");
                            }
                            writer.WriteLine(line);
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
