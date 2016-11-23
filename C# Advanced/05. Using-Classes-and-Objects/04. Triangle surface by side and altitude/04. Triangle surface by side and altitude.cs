using System;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Triangle
    {
        
        public double Side { get; set; }
        public double Altitude { get; set; }
        public double surface { get; private set; }
        internal void Surface()
        {
           surface = (Side * Altitude) / 2;
        }
    }
    class Program
    {
        static void Main()
        {
            Triangle surfaceTriangle = new Triangle();
            surfaceTriangle.Side = Convert.ToDouble(Console.ReadLine());
            surfaceTriangle.Altitude = Convert.ToDouble(Console.ReadLine());
            surfaceTriangle.Surface();
            Console.WriteLine("{0:F2}", surfaceTriangle.surface);
        }
    }
}
