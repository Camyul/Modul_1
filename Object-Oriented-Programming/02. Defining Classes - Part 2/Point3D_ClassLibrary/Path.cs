

namespace Point3D_ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Path
    {

        private List<Point3D> points;
        private List<Point3D> Points { get; set; }

     
        public void AddPoint(Point3D newPoint)
        {
              points.Add(newPoint);
        }
        public override string ToString()
        {
            return string.Join(",", this.Points);
        }

    }
   
}
