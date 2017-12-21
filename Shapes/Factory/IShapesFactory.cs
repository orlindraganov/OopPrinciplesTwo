using Shapes.Models.Contracts;

namespace Shapes.Factory
{
    public interface IShapesFactory
    {
        IShape CreateSquare(double side);

        IShape CreateRectangle(double width, double height);

        IShape CreateTriangle(double width, double height);
    }
}