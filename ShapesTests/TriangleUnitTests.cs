using System;
using Shapes;

namespace ShapesTests;

public class TriangleUnitTests
{
    [Test]
    public void CreateWithAllZeroSides()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, 0));
    }

    [Test]
    public void CreateWithZeroSide1()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0.1, 0.2, 0));
    }

    [Test]
    public void CreateWithNegativeLongSide()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 1, 1));
    }

    [Test]
    public void CreateWithZeroTooLongSide1()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 10, 2));
    }

    [Test]
    public void CreateWithZeroTooLongSide2()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3.14, 2.718, 5.987));
    }

    [Test]
    public void CalculateArea1()
    {
        Assert.IsTrue(new Triangle(3, 4, 5).Area().IsApproximatelyEqual(6));
    }

    [Test]
    public void CalculateArea2()
    {
        Assert.IsTrue(new Triangle(100, 100, 141.42).Area().IsApproximatelyEqual(5000));
    }

    [Test]
    public void CalculateArea3()
    {
        Assert.IsTrue(new Triangle(3.14, 2.718, 1).Area().IsApproximatelyEqual(1.308221));
    }

    [Test]
    public void IsRectangular()
    {
        Assert.IsTrue(new Triangle(3, 4, 5).IsRectangular());
    }

    [Test]
    public void IsNotRectangular()
    {
        Assert.IsTrue(!new Triangle(3.0001, 4, 5).IsRectangular());
    }
}
