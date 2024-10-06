using MIndbox.ShapeAreaLibrary.Figures;

namespace MIndbox.ShapeAreaLibrary.Tests;

public class TriangleTests
{
    [Fact]
    public void Constructor_ValidSides_ShouldSetSides()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.Equal(sideA, triangle.SideA);
        Assert.Equal(sideB, triangle.SideB);
        Assert.Equal(sideC, triangle.SideC);
    }
    
    [Theory]
    [InlineData(-3, 4, 5)]
    [InlineData(3, -4, 5)]
    [InlineData(3, 4, -5)]
    [InlineData(0, 4, 5)]
    [InlineData(3, 0, 5)]
    [InlineData(3, 4, 0)]
    public void Constructor_InvalidSides_ShouldThrowArgumentException(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
    
    [Fact]
    public void Constructor_ZeroSides_ShouldThrowArgumentException()
    {
        double sideA = 0;
        double sideB = 0;
        double sideC = 0;

        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
    
    [Fact]
    public void Constructor_ValidSides_ShouldIdentifyRightAngledTriangle()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.True(triangle.IsRightAngled);
    }
    
    [Fact]
    public void CalculateArea_ValidSides_ShouldReturnCorrectArea()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        
        var triangle = new Triangle(sideA, sideB, sideC);
        
        double expectedArea = 6;
        
        double actualArea = triangle.CalculateArea();

        Assert.Equal(expectedArea, actualArea, 4);
    }
}