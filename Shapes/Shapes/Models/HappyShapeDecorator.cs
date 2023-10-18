using Shapes.Contract;

namespace Shapes.Models;

public class HappyShapeDecorator : ShapeDecorator
{
    private const int MULTIPLIER = 2;

    public override int NumberOfCorners => GetCornersNumber();

    public override Mood MoodState => Mood.Happy;
    
    public HappyShapeDecorator(IShape shape) : base(shape) { }

    public override double Area()
    {
        return MULTIPLIER * shape.Area();
    }

    private int GetCornersNumber()
    {
        if (shape is Circle)
        {
            return 5;
        }
        return MULTIPLIER * shape.NumberOfCorners;
    }
}