using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DTest
{
    static class PathStorage
    {
        public static void SavePath(string filePath, Path path)
        {
            StreamWriter outputFile = new StreamWriter(filePath);
            using (outputFile)
            {
                foreach (Point3D point in path.PathOfPoints)
                {
                    outputFile.WriteLine(point.XCoordinate + " " + point.YCoordinate + " " + point.ZCoordinate);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();
            StreamReader inputFile = new StreamReader(filePath);
            using (inputFile)
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    string[] coordinates = line.Split(' ');
                    double x = double.Parse(coordinates[0]);
                    double y = double.Parse(coordinates[1]);
                    double z = double.Parse(coordinates[2]);

                    Point3D point = new Point3D(x, y, z);
                    path.PathOfPoints.Add(point);
                }
            }

            return path;
        }
    }
}
