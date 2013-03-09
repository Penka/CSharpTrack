using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DTest
{
    struct Point3D
    {

        public double XCoordinate { get; set; }

        public double YCoordinate { get; set; }

        public double ZCoordinate { get; set; }

        public Point3D(double x, double y, double z)
            : this()
        {
            XCoordinate = x;
            YCoordinate = y;
            ZCoordinate = z;
        }

        private static readonly Point3D coordinateSystemCenter = new Point3D(0, 0, 0);

        public static Point3D CoordinateSystemCenter
        {
            get
            {
                return coordinateSystemCenter;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("X coordinate is ");
            result.Append(this.XCoordinate);
            result.Append(". ");

            result.Append("Y coordinate is ");
            result.Append(this.YCoordinate);
            result.Append(". ");

            result.Append("Z coordinate is ");
            result.Append(this.ZCoordinate);
            result.Append(". ");

            return result.ToString();
        }

    }
}
