using Shapes.Models.Contracts;

namespace Shapes.Models
{
    public class Rectangle : Shape, IShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            var result = this.Width * this.Height;
            return result;
        }
    }
}
