using MIndbox.ShapeAreaLibrary.Interfaces;

namespace MIndbox.ShapeAreaLibrary.Figures;

public class Triangle : IShape
{
    public double SideA { get; private set; }
    public double SideB { get; private set; }
    public double SideC { get; private set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        // Все стороны треугольника должны быть больше нуля
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("All sides of a triangle must be greater than zero.");
        }

        // Треугольник не может иметь все стороны равные нулю.
        if (sideA == 0 && sideB == 0 && sideC == 0)
        {
            throw new ArgumentException("A triangle cannot have all sides equal to zero.");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }
}