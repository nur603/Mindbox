using MIndbox.ShapeAreaLibrary.Figures;

namespace MIndbox.ShapeAreaLibrary.Tests;

public class CircleTests
{
    [Fact]
    public void Constructor_ValidRadius_ShouldSetRadius()
    {
        double radius = 10;
        
        var circle = new Circle(radius);

        Assert.Equal(radius, circle.Radius);
    }
    
    [Theory]
    [InlineData(-5)]
    [InlineData(0)]
    [InlineData(101)]
    public void Constructor_InvalidRadius_ShouldThrowArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    
    [Fact]
    public void CalculateArea_ValidRadius_ShouldReturnCorrectArea()
    {
        double radius = 5;
        var circle = new Circle(radius);
        double expectedArea = Math.PI * Math.Pow(radius, 2);
        
        double actualArea = circle.CalculateArea();
        
        Assert.Equal(expectedArea, actualArea, 4);
    }
}