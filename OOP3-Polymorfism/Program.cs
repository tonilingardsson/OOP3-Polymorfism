namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geometry is the base class, and it points to its children: circle, square, and rectangle
            Geometry circle = new Circle(); // Same type (Geometry)
            Geometry square = new Square(); // but different objects
            Geometry rectangle = new Rectangle();

            // Store all the shapes in an array
            Geometry[] shapes = { circle, square, rectangle};

            // Polymophism in action: Same method call (Area()), different behavior.
            // Each shape calculates area differently base on its actual type
            // Loop through and call Area() on each shape
            foreach (var shape in shapes)
            {
                // shape.Area() calls the correct override for each shape type
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area():F2}");
            }
        }
    }
}