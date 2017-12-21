using System;
using Shapes.Factory;

namespace Shapes.Engine
{
    public class TestingEngine : ITestingEngine
    {
        private static readonly ITestingEngine SingleInstance = new TestingEngine();

        private readonly IShapesFactory factory;

        private TestingEngine()
        {
            this.factory = new ShapesFactory();
        }

        public static ITestingEngine Instance
        {
            get
            {
                return SingleInstance;
            }
        }

        public void Start()
        {
            TestShape("Triangle");
            TestShape("Rectangle");
            TestShape("Square");
        }

        public void TestShape(string shapeType)
        {
            var width = 3D;
            var height = 4D;
            var area = 0D;

            switch (shapeType)
            {
                case "Triangle":
                    area = width * height / 2;

                    var tri = factory.CreateTriangle(width, height);

                    Console.WriteLine(tri.GetType().ToString());
                    Console.WriteLine(tri.CalculateSurface() == area)
            ;
                    break;

                case "Rectangle":
                    area = width * height;

                    var rect = factory.CreateRectangle(width, height);

                    Console.WriteLine(rect.GetType().ToString());
                    Console.WriteLine(rect.CalculateSurface() == area);
                    break;

                case "Square":
                    area = width * width;

                    var sqr = factory.CreateSquare(width);

                    Console.WriteLine(sqr.GetType().ToString());
                    Console.WriteLine(sqr.CalculateSurface() == area);
                    break;

                default:
                    throw new ArgumentException("Shape type not valid");
            }
        }
    }
}
