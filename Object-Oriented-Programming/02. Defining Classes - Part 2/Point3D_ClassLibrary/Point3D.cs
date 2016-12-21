namespace Point3D_ClassLibrary
{
    using System;
    using System.Text;
    public struct Point3D
    {

        private static readonly Point3D center = new Point3D(0, 0, 0); // Static field

        //Constructor
        public Point3D(double x, double y, double z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public static Point3D Center // Static Property - Task 2
        {
            get
            {
                return center;
            }
        }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }
        public override string ToString()
        {
            StringBuilder pointToString = new StringBuilder();
            pointToString.Append("Coordinate:\tX\tY\tZ");
            pointToString.AppendLine();
            pointToString.Append(String.Format("Value:\t\t{0}\t{1}\t{2}\n", this.X, this.Y, this.Z));
            return pointToString.ToString();
          //return String.Format("Coordinate:\tX\tY\tZ\n\rValue:\t\t{0}\t{1}\t{2}\n", this.X, this.Y, this.Z);
        }
    }
}
