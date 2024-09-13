using LibCalculate.Figure;
using LibCalculate.Interfaces;

namespace LibCalculateTest;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void TriangleAreaTests() 
    {
        var triangle = new Triangle(3, 4, 5);
        double area = triangle.Area();
        Assert.AreEqual(6, area, 0.0001);
    }

    [Test]
    public void IsRightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightTriangle());
    }

    [Test]
    public void GenericShapeAreaTest()
    {
        IShape circle = new Circle(5);
        IShape triangle = new Triangle(3, 4, 5);

        double circleArea = ShapeUtils.GetArea(circle);
        double triangleArea = ShapeUtils.GetArea(triangle);

        Assert.AreEqual(Math.PI * 25, circleArea, 0.0001);
        Assert.AreEqual(6, triangleArea, 0.0001);
    }
}
