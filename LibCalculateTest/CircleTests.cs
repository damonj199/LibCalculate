using LibCalculate.Figure;

namespace LibCalculateTest;

[TestFixture]
public class CircleTests
{
    [Test]
    public void CircleAreaTest()
    {
        //arrange
        var circle = new Circle(5);
        //expeccted
        double area = circle.Area();
        //assert
        Assert.AreEqual(Math.PI * 25, area, 0.0001);
    }
}