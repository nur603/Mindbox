using MIndbox.ShapeAreaLibrary.Interfaces;

namespace MIndbox.ShapeAreaLibrary.Figures;

public class Circle : IShape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        if (!double.IsFinite(radius))
        {
            throw new ArgumentException("Radius must be a finite number.");
        }

        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than zero.");
        }

        if (radius > 100)
        {
            throw new ArgumentException("Radius cannot exceed 100.");
        }
        
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}