using System;

namespace _01_Shapes
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("radius", "Radius must be positive!");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI*this.Radius*this.Radius;
        }

        public double CalculatePerimeter()
        {
            return Math.PI*this.Radius*2;
        }
    }
}
