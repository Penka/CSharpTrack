using System;

namespace _3DTest
{
    class Test3D
    {
        static void Main(string[] args)
        {
            Point3D a = new Point3D(1, 1, 1);
            Point3D b = new Point3D(2, 2, 2);

            Path path = new Path();
            path.PathOfPoints.Add(a);
            path.PathOfPoints.Add(b);

            double dist = Distance3D.Distance(a, b);
            Console.WriteLine(dist);
            Console.WriteLine(a.ToString());

            string filePath = "../../result.txt";
            PathStorage.SavePath(filePath, path);
            Path newPath = PathStorage.LoadPath(filePath);
            foreach (Point3D point in newPath.PathOfPoints)
            {
                Console.WriteLine(point);
            }
        }
    }
}
