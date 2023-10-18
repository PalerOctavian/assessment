// See https://aka.ms/new-console-template for more information

using Shapes.Contract;
using Shapes.Models;
using Shapes.Service;

var shapes = new List<IShape>
{
    new Triangle(3, 2),  
    new Square(2),       
    new Rectangle(2, 3),
    new Circle(3),        
    new HappyShapeDecorator(new Square(4)),
    new SuperHappyShapeDecorator(new Circle(2))
};

ICornersCalculator service = new ShapeService();


Console.WriteLine(service.CornersSum(shapes));