using System;

namespace _3DTest
{
    static class Distance3D
    {
        public static double Distance(Point3D a, Point3D b)
        {
            double distance = Math.Sqrt(Math.Pow((a.XCoordinate - b.XCoordinate), 2) +
                Math.Pow((a.YCoordinate - b.YCoordinate), 2) + 
                Math.Pow((a.ZCoordinate - b.ZCoordinate), 2));

            return distance;
        }
    }
}
