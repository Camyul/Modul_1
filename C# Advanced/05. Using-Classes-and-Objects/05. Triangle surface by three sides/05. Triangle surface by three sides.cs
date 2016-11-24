using System;

namespace Triangle_surface_by_three_sides
{
    class Triangle
    {
        private double semiParameter;
        public double area { get; private set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        
        public void Area()
        {
            semiParameter = (FirstSide + SecondSide + ThirdSide) / 2;
            area = Math.Sqrt(semiParameter * (semiParameter - FirstSide) * 
                (semiParameter - SecondSide) * (semiParameter - ThirdSide));
        }
    }
    class TriangleSurfaceByThreeSides
    {
        static void Main()
        {
            Triangle myTriangle = new Triangle();
            myTriangle.FirstSide = Convert.ToDouble(Console.ReadLine());
            myTriangle.SecondSide = Convert.ToDouble(Console.ReadLine());
            myTriangle.ThirdSide = Convert.ToDouble(Console.ReadLine());
            myTriangle.Area();
            Console.WriteLine("{0:F2}", myTriangle.area);
        }
    }
}
