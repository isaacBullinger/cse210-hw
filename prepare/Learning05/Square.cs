using System.Formats.Asn1;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side): base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        double area = Math.Pow(_side, 2);
        return area;
    }
}