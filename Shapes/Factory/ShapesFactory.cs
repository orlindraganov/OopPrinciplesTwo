using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Models;
using Shapes.Models.Contracts;

namespace Shapes.Factory
{
    public class ShapesFactory : IShapesFactory
    {
        public IShape CreateSquare(double side)
        {
            return new Square(side);
        }

        public IShape CreateRectangle(double width, double height)
        {
            return new Rectangle(width, height);
        }

        public IShape CreateTriangle(double width, double height)
        {
            return new Triangle(width, height);
        }
    }
}
