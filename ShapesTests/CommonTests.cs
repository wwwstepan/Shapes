using System.Collections.Generic;
using Shapes;

namespace ShapesTests;

public class CommonTests
{
    [Test]
    public void CalculateCollcection()
    {
        var shapes = new List<Shape>();
        shapes.Add(new Circle(3));
        shapes.Add(new Triangle(2, 2, 2));
        shapes.Add(new Circle(1e-7));

        Assert.IsTrue(shapes[0].Area().IsApproximatelyEqual(28.27434));
        Assert.IsTrue(shapes[1].Area().IsApproximatelyEqual(1.732051));
        Assert.IsTrue(shapes[2].Area().IsApproximatelyEqual(3.14159e-14));
    }
}
