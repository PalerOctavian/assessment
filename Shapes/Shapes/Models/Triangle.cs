using Shapes.Contract;

namespace Shapes.Models;

public class Triangle : IShape
{
    private const int CORNERS = 3;
    
    private readonly double _base;
    private readonly double height;

    public int NumberOfCorners => CORNERS;
    
    public Triangle(double baseValue, double height)
    {
        _base = baseValue;
        this.height = height;
    }

    public double Area()
    {
        return (_base * height) / 2;
    }
}