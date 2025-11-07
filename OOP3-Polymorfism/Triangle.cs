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

        // Constructor for Triangle
        public Triangle()
        {
            Base = 3;
            Height = 4;
        }

        // Declaring Triangle's method for its area
        public override double Area()
        {
            return Base * Height /2;
        }
    }
}