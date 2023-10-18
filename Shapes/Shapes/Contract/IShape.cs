namespace Shapes.Contract;

public interface IShape
{
    double Area();
    
    int NumberOfCorners { get; }
}