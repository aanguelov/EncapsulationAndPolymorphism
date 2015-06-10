using System;

namespace _01_Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            IShape[] shapes = new IShape[]
            {
                new Triangle(5, 6, 2, 3),
                new Circle(5.5),
                new Rectangle(8, 4.5), 
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}, Area: {1:F2}, Perimeter: {2:F2}", 
                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
