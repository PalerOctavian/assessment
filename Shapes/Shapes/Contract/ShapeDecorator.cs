using Shapes.Models;

namespace Shapes.Contract;

public abstract class ShapeDecorator : IShape
{
    protected IShape shape;

    public virtual int NumberOfCorners => shape.NumberOfCorners;
    
    public abstract Mood MoodState { get; }
    
    protected ShapeDecorator(IShape shape)
    {
        this.shape = shape;
    }
    
    public virtual double Area()
    {
        return shape.Area();
    }
}