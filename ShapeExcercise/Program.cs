namespace ShapeExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", "Red", 5);
            Triangle triangle = new Triangle("Triangle", "Blue", 5, 3);
            Rectangle rectangle = new Rectangle("Rectangle", "Green", 5, 4);

            Console.WriteLine(circle.GetInfo());
            Console.WriteLine(triangle.GetInfo());
            Console.WriteLine(rectangle.GetInfo());
        }
    }
}
