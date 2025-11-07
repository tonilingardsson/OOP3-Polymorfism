namespace Polymorphism
{
  public class Square : Geometry
  {
    // Declaring Side property and its type
    public double Side {get; set;}

    // Constructor with Side = 8, we need to get an area = 64, 8x8
    public Square()
    {
        Side = 8; 
    }

    // Parameterized constructor 
    public Square(double side)
    {
      Side = side;
    }

    // Declaring Square's method for Area
    public override double Area()
    {
        // Square's area is side^2
        return Side*Side;
    } 

    // Square's Perimeter method
    public override double Perimeter()
    {
        // Square's area is side x 4
        return Side*4;
    } 
  }  
}