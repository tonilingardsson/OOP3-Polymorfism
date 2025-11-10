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
        public double THeight {get; set;}
        public double Hypotenuse {get; set;}

        // Constructor for Triangle
        public Triangle()
        {
            Base = 3;
            THeight = 4;
            // Calculate hypotenuse for right triangle
            Hypotenuse = Math.Sqrt(Base * Base + THeight * THeight); // = 5

        }

        // Parameterized method
        public Triangle(double _base, double tHeight)
        {
            Base = _base;
            THeight = tHeight;
            // Calculate hypotenuse for right triangle
            Hypotenuse = Math.Sqrt(Base * Base + THeight * THeight);
        }

        // Declaring Triangle's method for its area
        public override double Area()
        {
            return Base * THeight /2;
        }

        // Triangle's Perimeter method 
        public override double Perimeter()
        {
            return Base + THeight + Hypotenuse;
        }
    }
}