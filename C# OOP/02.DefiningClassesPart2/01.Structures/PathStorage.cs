using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structures
{
    public static class PathStorage
    {
        public static void LoadPointsFromFile(string filePath, Path path)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] values = line.Split(new [] {(' ')}, StringSplitOptions.RemoveEmptyEntries);
                        path.PointSequence.Add(new Point3D(float.Parse(values[0]),
                            float.Parse(values[1]), float.Parse(values[2])));
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileLoadException)
            {
                Console.WriteLine("File {0} does not exists", filePath);
            }
            catch (IOException)
            {
                Console.WriteLine("Error occured while processing files: {0}", filePath);
            }
        }

        public static void SavePointsInFile(string filePath, Path path)
        {
            try
            {
                StreamWriter writer = new StreamWriter(filePath);
                using (writer)
                {
                    for (int i = 0; i < path.PointSequence.Count; i++)
                    {
                        string line = path.PointSequence[i].ToString();
                        string[] arr = line.Split(':', ',');
                        writer.WriteLine(arr[1] + " " + arr[3] + " " + arr[5]);
                    } 
                }
            }
            catch (FileLoadException)
            {
                Console.WriteLine("File {0} does not exists", filePath);
            }
            catch (IOException)
            {
                Console.WriteLine("Error occured while processing files: {0}", filePath);
            }
        }
    }
}
