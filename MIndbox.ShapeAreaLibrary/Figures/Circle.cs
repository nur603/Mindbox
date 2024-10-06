using MIndbox.ShapeAreaLibrary.Interfaces;

namespace MIndbox.ShapeAreaLibrary.Figures;

public class Circle : IShape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}