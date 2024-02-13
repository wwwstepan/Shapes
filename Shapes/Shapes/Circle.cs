using System;

namespace Shapes;

/// <summary>
/// Геометрическая фигура - круг
/// </summary>
public class Circle : Shape
{
    private readonly double _radius;

    /// <summary>
    /// Конструктор круга - по длине радиуса
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(_radius), "The radius of the circle must be a positive number");

        _radius = radius;
    }

    /// <summary>
    /// Площадь круга πR²
    /// </summary>
    public override double Area() => Math.PI * _radius * _radius;
}
