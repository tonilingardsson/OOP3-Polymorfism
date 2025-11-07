namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geometry is the base class, and it points to its children: circle, square, and rectangle
            Geometry circle = new Circle(); // Same type (Geometry)
            Geometry circleD = new Circle(8); // Parameterized Circle method
            Geometry square = new Square(); // but different objects
            Geometry squareD = new Square(5); // Parameterized Square method
            Geometry rectangle = new Rectangle();
            Geometry rectangleD = new Rectangle(4,6); // Parameterized Rectangle method
            Geometry triangle = new Triangle();
            Geometry triangleD = new Triangle(5,6); // Parameterized Triangle method

            // Store all the shapes in an array
            Geometry[] shapes = { circle, circleD, square, squareD, rectangle, rectangleD, triangle, triangleD};

            // Polymophism in action: Same method call (Area()), different behavior.
            // Each shape calculates area differently base on its actual type
            // Loop through and call Area() on each shape
            foreach (var shape in shapes)
            {
                // shape.Area() calls the correct override for each shape type
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area():F2}");
                Console.WriteLine($"Perimeter of {shape.GetType().Name}: {shape.Perimeter():F2}");
            }
        }
    }
}