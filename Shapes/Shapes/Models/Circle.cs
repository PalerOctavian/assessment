using Shapes.Contract;

namespace Shapes.Models;

public class Circle : IShape
{
    private const int CORNERS = 0;
    
    private readonly double radius;
    
    public int NumberOfCorners => CORNERS;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    public double Area()
    {
        return Math.PI * radius * radius;

    }

    
}