using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3DPointCoordinates
{
    class PointCoordinates
    {
        static void Main()
        {
            //1:
            //Console.WriteLine("Input data for X-coordinate:");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input data for Y-coordinate:");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input data for Z-coordinate:");
            //int z = int.Parse(Console.ReadLine());
            //Point3D somePoint = new Point3D(x, y, z);
            //Console.WriteLine("The coordinates for your 3D point are: {0}", somePoint.ToString());

            //2:
            //Console.WriteLine("The coordinates for your starting point for the system are: {0}", Point3D.Start.ToString());
            
            //3:
            //Point3D first = new Point3D(0, 1, 3);
            //Point3D second = new Point3D(0, 1, 4);
            //Console.WriteLine("Distance between {0} and {1}: {2}", first.ToString(), second.ToString(),CalculateDistance.GiveMeDistance(first, second));

            //4:
            Path somePath = new Path();
            somePath.AddPointInPath(new Point3D(0, 6, 3));
            somePath.AddPointInPath(new Point3D(0, 0, 33));
            foreach (var point in somePath.PointsInPath )
            {
                Console.WriteLine(point.ToString());
            }
            //somePath.ClearPath();
            PathStorage.SaveMyPath(somePath);
            Console.WriteLine("Path saved!");
            Console.WriteLine();
            Console.WriteLine("Reading file from file:");
            foreach (Point3D point in PathStorage.LoadPathFromFile())
            {
                Console.WriteLine(point.ToString());
            }
        }
    }
}
