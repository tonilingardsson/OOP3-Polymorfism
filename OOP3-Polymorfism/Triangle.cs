using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Triangle : Geometry
    {
        // Declaring triangle's properties and their types
        public double Base {get; set;}
        public double Height {get; set;}
        public double Hypotenuse {get; set;}

        // Constructor for Triangle
        public Triangle()
        {
            Base = 3;
            Height = 4;
            // Calculate hypotenuse for right triangle
            Hypotenuse = Math.Sqrt(Base * Base + Height * Height); // = 5

        }

        // Parameterized method
        public Triangle(double _base, double height)
        {
            Base = _base;
            Height = height;
            // Calculate hypotenuse for right triangle
            Hypotenuse = Math.Sqrt(Base * Base + Height * Height);
        }

        // Declaring Triangle's method for its area
        public override double Area()
        {
            return Base * Height /2;
        }

        // Triangle's Perimeter method 
        public override double Perimeter()
        {
            return Base + Height + Hypotenuse;
        }
    }
}