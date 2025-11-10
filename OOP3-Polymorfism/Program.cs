namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
{
    bool running = true;
    
    while (running)
    {
        // TODO: Display menu
        Console.WriteLine("\n=== GEOMETRY CALCULATOR ===");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Square");
        Console.WriteLine("3. Rectangle");
        Console.WriteLine("4. Triangle");
        Console.WriteLine("5. Exit");
        Console.Write("\nChoose a shape (1-5): ");
        
        // TODO: Get user choice
        string choice = Console.ReadLine();
        
        // TODO: Handle choice with switch statement
        switch (choice)
        {
            case "1":
                // Ask user to create a circle
                Console.WriteLine("Enter the radius of the circle: ");
                double.TryParse(Console.ReadLine(), out double radius);
                // Creates the circle
                Geometry circle = new Circle(radius);
                Console.WriteLine($"\n✅ Circle created!");
                Console.WriteLine($"  Area: {circle.Area():F2}");
                Console.WriteLine($"  Perimeter: {circle.Perimeter():F2}");
                break;
            case "2":
                // Ask user to create a square
                Console.WriteLine("Enter the side size of the square: ");
                double.TryParse(Console.ReadLine(), out double side);
                // Creates the Square
                Geometry square = new Square(side);
                Console.WriteLine($"\n✅ Square created!");
                Console.WriteLine($"  Area: {square.Area():F2}");
                Console.WriteLine($"  Perimeter: {square.Perimeter():F2}");
                break;
            case "3":
                // Ask user to create a rectangle, starting with the width
                Console.WriteLine("Enter the width of the rectangle: ");
                double.TryParse(Console.ReadLine(), out double width);
                // Ask user to continue with the height of the rectangle
                Console.WriteLine("Enter the height of the rectangle: ");
                double.TryParse(Console.ReadLine(), out double height);
                // Creates the Rectangle
                Geometry rectangle = new Rectangle( width,  height);
                Console.WriteLine($"\n✅ Rectangle created!");
                Console.WriteLine($"  Area: {rectangle.Area():F2}");
                Console.WriteLine($"  Perimeter: {rectangle.Perimeter():F2}");
                break;
            case "4":
                // Ask user to create a triangle, starting with the base
                Console.WriteLine("Enter the base of the triangle: ");
                double.TryParse(Console.ReadLine(), out double _base);
                // Ask user to continue with the height of the triangle
                Console.WriteLine("Enter the height of the triangle: ");
                double.TryParse(Console.ReadLine(), out double tHeight);
                // Creates the triangle
                Geometry triangle = new Triangle( _base,  tHeight);
                Console.WriteLine($"\n✅ Triangle created!");
                Console.WriteLine($"  Area: {triangle.Area():F2}");
                Console.WriteLine($"  Perimeter: {triangle.Perimeter():F2}");
                break;
            case "5":
                running = false;
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
        // static void Main(string[] args)
        // {
        //     // Geometry is the base class, and it points to its children: circle, square, and rectangle
        //     Geometry circle = new Circle(); // Same type (Geometry)
        //     Geometry circle = new Circle(8); // Parameterized Circle method
        //     Geometry square = new Square(); // but different objects
        //     Geometry square = new Square(5); // Parameterized Square method
        //     Geometry rectangle = new Rectangle();
        //     Geometry rectangleD = new Rectangle(4,6); // Parameterized Rectangle method
        //     Geometry triangle = new Triangle();
        //     Geometry triangleD = new Triangle(5,6); // Parameterized Triangle method

        //     // Store all the shapes in an array
        //     Geometry[] shapes = { circle, circle, square, square, rectangle, rectangleD, triangle, triangleD};

        //     // Polymophism in action: Same method call (Area()), different behavior.
        //     // Each shape calculates area differently base on its actual type
        //     // Loop through and call Area() on each shape
        //     foreach (var shape in shapes)
        //     {
        //         // shape.Area() calls the correct override for each shape type
        //         Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area():F2}");
        //         Console.WriteLine($"Perimeter of {shape.GetType().Name}: {shape.Perimeter():F2}");
        //     }
        // }
    }
}