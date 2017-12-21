using Shapes.Models.Contracts;

namespace Shapes.Models
{
    public class Square : Rectangle, IShape
    {
        public Square(double side) : base(side, side)
        {
        }

        public Square(double width, double height) : base(width, height)
        {
        }
    }
}
