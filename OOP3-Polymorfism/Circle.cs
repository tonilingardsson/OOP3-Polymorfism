using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : Geometry
    {
        // Declaring Radius property and its type
        public double Radius {get; set;}

        // Constructor with Radius = 4 (fixed value)
        public Circle()
        {
            Radius = 4; // Fixed value 
        }

        // Parameterized constructor - dynamic value
        public Circle(double radius)
        {
            Radius = radius;  
        }

    // Declaring Circle's method for Area
        public override double Area()
        {
            // Circle's area is π x r^2
            return Math.PI * Radius * Radius;
        }
    }
}