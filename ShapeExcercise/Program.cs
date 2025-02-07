using System.Collections;

namespace ShapeExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            
            shapes.Add(new Circle("Circle", "Red", 20));
            shapes.Add(new Triangle("Triangle", "Blue", 5, 3));
            shapes.Add(new Circle("Circle", "Blue", 30));
            shapes.Add(new Rectangle("Rectangle", "Green", 5, 4));
            shapes.Add(new Triangle("Triangle", "Red", 3, 6));
            shapes.Add(new Circle("Circle", "Yellow", 10));
            shapes.Sort();
            foreach (Shape shape in shapes)
            {
                if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    Console.WriteLine(circle.GetInfo());
                }
            }
        }
    }
}
