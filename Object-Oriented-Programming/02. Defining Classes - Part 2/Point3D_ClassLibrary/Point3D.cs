namespace Point3D_ClassLibrary
{
    using System;
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static Point3D o = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Point3D O { 
            get
            {
                return o;
            }
    }
        public override string ToString()
        {
            return String.Format("Coordinate:\tX\tY\tZ\nValue:\t\t{0}\t{1}\t{2}", this.x, this.y, this.z);
        }
    }
}
