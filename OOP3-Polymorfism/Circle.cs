namespace Polymorphism
{
    public class Circle : Geometry
    {
        // Declaring Radius property and its type
        public double Radius {get; set;}

        public Circle()
        {
            Radius = 4; // Fixed value 
        }

        public override double Area()
        {
            // Circle's area is π x r^2
            return Math.PI * Radius * Radius;
        }
    }
}