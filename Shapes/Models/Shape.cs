using Bytes2you.Validation;

using Shapes.Models.Contracts;

namespace Shapes.Models
{
    public abstract class Shape : IShape
    {
        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                Guard.WhenArgument(value, "Width cannot be negative").IsLessThan(0).Throw();
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Guard.WhenArgument(value, "Height cannot be negative").IsLessThan(0).Throw();
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
