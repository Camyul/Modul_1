namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        internal virtual double Surface()
        {
            return Width * Height;
        }

        public override double CalculateSurface()
        {
            return Surface();
        }
    }
}
