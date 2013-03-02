using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3DPointCoordinates
{
    public class Path
    {
        public Path()
        { 
        }

        private List<Point3D> pointsInPath = new List<Point3D>();

        public List<Point3D> PointsInPath
        {
            get { return this.pointsInPath; }
        }

        public List<Point3D> AddPointInPath(Point3D somePoint)
        {
            pointsInPath.Add(somePoint);
            return pointsInPath;
        }

        public void ClearPath()
        {
            pointsInPath.Clear();
            Console.WriteLine("Path {0} cleared!", this.ToString());
        }

        public override string ToString()
        {
            return "you created";
        }
    }
}
