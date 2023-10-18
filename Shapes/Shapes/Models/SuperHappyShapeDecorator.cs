using Shapes.Contract;

namespace Shapes.Models;

public class SuperHappyShapeDecorator : ShapeDecorator
{
    private const int MULTIPLIER = 3;

    public override int NumberOfCorners => GetCornersNumber();

    public override Mood MoodState => Mood.SuperHappy;
    
    public SuperHappyShapeDecorator(IShape shape) : base(shape) { }

    public override double Area()
    {
        return MULTIPLIER * shape.Area();
    }

    private int GetCornersNumber()
    {
        if (shape is Circle)
        {
            return 10;
        }

        return MULTIPLIER * shape.NumberOfCorners;
    }
}