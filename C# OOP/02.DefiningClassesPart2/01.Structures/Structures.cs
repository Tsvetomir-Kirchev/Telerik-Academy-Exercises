using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structures
{
    class Structures
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(12, 21, 5);
            Point3D secondPoint = new Point3D(234, 432, 84);

            float distance = Point3DCalculations.CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine("First Point: {0}", firstPoint.ToString());
            Console.WriteLine("Second Point: {0}", secondPoint.ToString());
            Console.WriteLine("Distance: {0}", distance);

            Path path = new Path();
            string filePath = @"..\..\pointValues.txt";

            PathStorage.LoadPointsFromFile(filePath, path);
            Console.WriteLine("Loaded from text file: {0}", filePath);
            foreach (var point in path.PointSequence)
            {
                Console.WriteLine(point.ToString());
            }

            path.PointSequence.Clear();
            path.PointSequence.Add(new Point3D(123, 332, 4));
            path.PointSequence.Add(new Point3D(33, 32, 43));
            path.PointSequence.Add(new Point3D(25, 21, 22));
            path.PointSequence.Add(new Point3D(3, 2, 4));

            string outputFile = @"..\..\outputFile.txt";
            PathStorage.SavePointsInFile(outputFile, path);

            path.PointSequence.Clear();
            PathStorage.LoadPointsFromFile(outputFile, path);

            Console.WriteLine("These Point3D objects was saved in {0}: ", outputFile);
            foreach (var point in path.PointSequence)
            {
                Console.WriteLine(point.ToString());
            }
        }
    }
}
