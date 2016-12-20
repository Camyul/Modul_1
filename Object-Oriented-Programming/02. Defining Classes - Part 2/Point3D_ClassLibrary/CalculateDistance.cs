

namespace Point3D_ClassLibrary
{
    using System;
    public static class Distance
    {
        //Calculate distance between two point
        public static double Calculate(Point3D a, Point3D b)
        {
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2) + Math.Pow((a.Z - b.Z), 2));
        }
    }
}
