using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rectangle : Geometry
    {
        // Declare properties Width and Height and their types
        public double Width {get; set;}
        public double Height {get; set;}

        // Constructor for Rectangle - fixed values
        public Rectangle()
        {
            Width = 5.2;
            Height = 4.55;
        }

        // Parameterized constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Declaring Rectangle's method for Area
        public override double Area()
        {
            // Rectangles area is width x height
            return Width * Height;
        }

        // Rectangle's Perimeter method
        public override double Perimeter()
        {
            // Rectangles perimeter is 2 x width + 2 x height
            return 2 * Width + 2 * Height;
        }

    }
}