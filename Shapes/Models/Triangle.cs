using Shapes.Models.Contracts;

namespace Shapes.Models
{
    public class Triangle : Shape, IShape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            var result = this.Width * this.Height / 2;
            return result;
        }
    }
}
