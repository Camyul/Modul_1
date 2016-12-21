

namespace Point3D_ClassLibrary
{
    using System.Collections.Generic;

    public class Path
    {

        private List<Point3D> pointList = new List<Point3D>(); //Field
       
        private List<Point3D> PointList { //Property
            get
            {
                return this.pointList;
            }
            set
            {
                this.pointList = value;
            }
        }

        public int CountPoints //Property
        {
            get { return this.PointList.Count; }
        }
        public Point3D this[int index] // Indexer
        {
            get { return this.PointList[index]; }
            set { this.PointList[index] = value; }
        }
        public void AddPoint(Point3D newPoint)  // Method
        {
            this.PointList.Add(newPoint);
        }
        public void RemovePoint(Point3D newPoint)  // Method
        {
            this.PointList.Remove(newPoint);
        }
        public void ClearPoint()   // Method
        {
            this.PointList.Clear();
        }

        public override string ToString()// Override method
        {
            return string.Join("", this.PointList);
        }

    }
   
}
