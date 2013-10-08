using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structures
{
    public static class Point3DCalculations
    {
        public static float CalculateDistance(Point3D firstPoint, Point3D seconPoint)
        {
            float deltaX = firstPoint.X - seconPoint.X;
            float deltaY = firstPoint.Y - seconPoint.Y;
            float deltaZ = firstPoint.Z - seconPoint.Z;

            float distance = (float)Math.Sqrt(
                (deltaX * deltaX) +
                (deltaY * deltaY) +
                (deltaZ * deltaZ));

            return distance;
        }
    }
}
