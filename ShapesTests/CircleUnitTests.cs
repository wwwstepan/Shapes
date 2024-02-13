using System;
using Shapes;

namespace ShapesTests;

public class CircleUnitTests
{
    [Test]
    public void CreateCircleWithZeroRadius()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
    }

    [Test]
    public void CreateCircleWithNegativeRadius()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-0.1));
    }

    [Test]
    public void CreateCorrectCircle1()
    {
        Assert.DoesNotThrow(() => new Circle(1));
    }

    [Test]
    public void CreateCorrectCircle2()
    {
        Assert.DoesNotThrow(() => new Circle(.0987));
    }

    [Test]
    public void CalculateCircleArea1()
    {
        var circle = new Circle(2.5);
        var area = circle.Area();
        Assert.IsTrue(area.IsApproximatelyEqual(19.63495408));
    }

    [Test]
    public void CalculateCircleArea2()
    {
        var area = new Circle(5.641896).Area();
        Assert.IsTrue(area.IsApproximatelyEqual(100));
    }

    [Test]
    public void CalculateCircleArea3()
    {
        var area = new Circle(1_000_000_000).Area();
        Assert.IsTrue(area.IsApproximatelyEqual(3_141_592_653_589_000_000)); // 3_141_592_653_589_793_238
    }
}
