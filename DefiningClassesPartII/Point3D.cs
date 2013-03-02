using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3DPointCoordinates
{
    public struct Point3D
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int CoordinateZ { get; set; }

        static private readonly Point3D start = new Point3D(0, 0, 0);

        public Point3D(int CoordinateX, int CoordinateY, int CoordinateZ)
            : this()
        {
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
            this.CoordinateZ = CoordinateZ;
        }

        static public Point3D Start
        {
            get { return start; }
        }

        public override string ToString()
        {
            return "[" + this.CoordinateX + ", " + this.CoordinateY + ", " + this.CoordinateZ + " " + "]";
        }
    }
}
