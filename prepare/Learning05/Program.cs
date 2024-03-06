using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Console.Clear();

        Square square = new Square("red", 1.5);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        // Console.WriteLine();

        Rectangle rectangle = new Rectangle("blue", 2.5, 7.5);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine();

        Circle circle = new Circle("yellow", 3.14);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"This {color} shape's area is {area}.");
        }
    }
}