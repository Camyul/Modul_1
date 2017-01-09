namespace Shapes
{
    using System;
    using System.Collections.Generic;
    class Shapes
    {
        static void Main()
        {
            List<Shape> listShape = new List<Shape>  //Create list of Shapes
            {
                new Rectangle(4,5),
                new Triangle(4,5),
                new Rectangle(3.5,5.2),
                new Triangle(3.4,2.5),
                new Square(5,5),
                new Square(1.55,1.55)
            };

            foreach (var shape in listShape)  //Print Surface of differrent shapes
            {
                Console.WriteLine(shape.GetType().Name + "\t:Surface is: {0:F2}", shape.CalculateSurface());
            }
        }
    }
}
