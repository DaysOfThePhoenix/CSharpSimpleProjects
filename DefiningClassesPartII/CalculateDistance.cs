using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3DPointCoordinates
{
    static public class CalculateDistance
    {
        static public double GiveMeDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow(firstPoint.CoordinateX  - secondPoint.CoordinateX, 2) + Math.Pow(firstPoint.CoordinateY - secondPoint.CoordinateY, 2) + Math.Pow(firstPoint.CoordinateZ - secondPoint.CoordinateZ, 2));
            return distance;
        }
    }
}
