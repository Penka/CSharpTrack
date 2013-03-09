using System;
using System.Collections.Generic;

namespace _3DTest
{
    class Path
    {
        private List<Point3D> path;
        
        public List<Point3D> PathOfPoints
        {
            get
            {
                return this.path;
            }
            private set
            {
                this.path = value;
            }
        }
       
        public Path()
        {
            path = new List<Point3D>();
        }
    }
}
