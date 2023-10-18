using Shapes.Contract;

namespace Shapes.Service;

public class ShapeService : IShapeService
{
    public double AreaSum(IEnumerable<IShape> shapes)
    {
        return shapes.Sum(shape => shape.Area());
    }

    public int CornersSum(IEnumerable<IShape> shapes)
    {
        return shapes.Sum(shape => shape.NumberOfCorners);
    }
}