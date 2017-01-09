namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        protected virtual double Surface()
        {
            return (Width * Height) / 2;
        }

        public override double CalculateSurface()
        {
            return Surface();
        }
    }
}
