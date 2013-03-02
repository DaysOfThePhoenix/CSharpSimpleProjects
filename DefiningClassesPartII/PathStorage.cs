using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01._3DPointCoordinates
{
    public static class PathStorage
    {
        public static void SaveMyPath(Path somePath)
        {
            using (StreamWriter writer = new StreamWriter(@".../.../MyPaths.txt"))
            {
                writer.WriteLine("Points for the input path: ");
                foreach (Point3D  point in somePath.PointsInPath)
                {
                    writer.WriteLine(point.ToString());
                }
            }
        }

        public static List<Point3D> LoadPathFromFile()
        {
            List<Point3D> loaded = new List<Point3D>();

            using (StreamReader reader = new StreamReader(@".../.../LoadFromhere.txt"))
            {
                string line = reader.ReadLine();
                while (line !=null)
                {
                    string[] coord = line.Split('[', ',', ']',' ');
                    List<int> coordinates = new List<int>();
                    for (int i = 0; i < coord.Length ; i++)
                    {
                        int someInt;
                        if (int.TryParse(coord[i], out someInt))
                        {
                            coordinates.Add(someInt);
                        }
                    }
                    Point3D point = new Point3D();
                    
                    point.CoordinateX = coordinates[0];
                    point.CoordinateY = coordinates[1];
                    point.CoordinateZ = coordinates[2];
                    loaded.Add(point);
                    line = reader.ReadLine();
                }
            }
            return loaded;
        }
    }
}
