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

        // Constructor for Rectangle
        public Rectangle()
        {
            Width = 5.2;
            Height = 4.55;
        }

        // Declaring Rectangle's method for Area
        public override double Area()
        {
            // Rectangles area is width x height
            return Width * Height;
        }

    }
}