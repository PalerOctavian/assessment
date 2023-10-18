namespace Shapes.Contract;

public interface ICornersCalculator
{
    int CornersSum(IEnumerable<IShape> shapes);
}