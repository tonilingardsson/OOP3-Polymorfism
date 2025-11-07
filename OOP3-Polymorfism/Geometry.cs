using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Abstract classes requires that children classes apply/override its methods
    public abstract class Geometry
    {
        // Create an abstract method called Area()
        public abstract double Area();

        // Calculate the perimeter
        public abstract double Perimeter();
    }
}