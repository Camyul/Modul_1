using System;

namespace Shapes
{
    class Square : Rectangle
    {
        public Square(double width, double height) : base(width, height)
        {
            if (width != height)
            {
                throw new ArgumentOutOfRangeException("This is Square, Width and Height must be equal");
            }
        }

        public override double CalculateSurface()
        {
            return Width * Height ;
        }
    }
}
