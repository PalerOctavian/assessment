namespace Shapes.Contract;

public interface IAreaCalculator
{
    double AreaSum(IEnumerable<IShape> shapes);
}