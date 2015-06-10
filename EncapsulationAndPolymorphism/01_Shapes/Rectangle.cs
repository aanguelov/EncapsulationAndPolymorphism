namespace _01_Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateArea()
        {
            return this.Height*this.Width;
        }

        public override double CalculatePerimeter()
        {
            return (this.Height + this.Width)*2;
        }
    }
}
