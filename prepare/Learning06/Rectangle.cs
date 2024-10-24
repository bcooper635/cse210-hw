public class Rectangle : Shape
{
    private double _side;

    private double _width;

    public Rectangle(double side, double width, string color) : base (color)
    {
        _side = side;
        _width = width;
    }

    public override double GetArea()
    {
        return _side*_width;
    }
}