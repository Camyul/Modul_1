using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_surface_by_two_sides_and_an_angle
{
    class Triangle
    {
        public double area { get; private set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double Angle { get; set; }
        
        public Triangle(double firstSide, double seconSide, double angle)//Constructor
        {
            FirstSide = firstSide;
            SecondSide = seconSide;
            Angle = angle;
        }
        public double Area()
        {
            area = (Math.Sin(AngleToRadian(Angle)) * (FirstSide) * (SecondSide)) / 2;
            return area;
        }
        private double AngleToRadian(double Angle)
        {
            return (Math.PI * Angle) / 180;
        }
    }
   
    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main()
        {
            
            double sideOne = Convert.ToDouble(Console.ReadLine());
            double sideTwo = Convert.ToDouble(Console.ReadLine());
            double angleBetweenSide = Convert.ToDouble(Console.ReadLine());
            Triangle myTriangle = new Triangle(sideOne, sideTwo, angleBetweenSide);
            myTriangle.Area();
            Console.WriteLine("{0:F2}", myTriangle.area);
        }
    }
}
 