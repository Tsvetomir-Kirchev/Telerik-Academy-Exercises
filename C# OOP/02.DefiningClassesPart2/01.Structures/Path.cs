using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structures
{
    public class Path
    {
        public List<Point3D> PointSequence { get; set; }

        public Path()
        {
            PointSequence = new List<Point3D>();
        }
    }
}
