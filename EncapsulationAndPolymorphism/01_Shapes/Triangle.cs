using System;
namespace _01_Shapes
{
    class Triangle : BasicShape
    {
        //private double firstBaseSplit;
        //private double secondBaseSplit;

        public Triangle(double width, double height, double firstBaseSplit, double secondBaseSplit)
            : base(width, height)
        {
            this.FirstBaseSplit = firstBaseSplit;
            this.SecondBaseSplit = secondBaseSplit;
        }

        public double FirstBaseSplit { get; set; }

        public double SecondBaseSplit { get; set; }

        public override double CalculateArea()
        {
            return (this.Height * this.Width)/2;
        }

        public override double CalculatePerimeter()
        {
            double sideA = Math.Sqrt((Math.Pow(this.Height, 2) + Math.Pow(this.FirstBaseSplit, 2)));
            double sideB = Math.Sqrt((Math.Pow(this.Height, 2) + Math.Pow(this.SecondBaseSplit, 2)));
            double perimeter = sideA + sideB + this.Width;
            return perimeter;
        }
    }
}
