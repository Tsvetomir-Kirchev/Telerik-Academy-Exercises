using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structures
{
    public struct Point3D
    {
        private static readonly Point3D pointZero = new Point3D();

        public static Point3D PointZero
        {
            get
            {
                return pointZero;
            }
        }

        public Point3D(float x, float y, float z) 
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        public override string ToString()
        {
            return String.Format("X: {0}, Y: {1}, Z: {2}", X, Y, Z);
        }
    }
}
