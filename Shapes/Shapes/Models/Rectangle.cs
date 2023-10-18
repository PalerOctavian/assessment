using Shapes.Contract;

namespace Shapes.Models;

public class Rectangle : IShape
{
    private const int CORNERS = 4;
        
    private readonly double _length;
    private readonly double _width;

    public int NumberOfCorners => CORNERS;
    
    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }
    
    public double Area()
    {
        return _length * _width;
    }
}