using System;

namespace Shapes;

/// <summary>
/// Геометрическая фигура - треугольник
/// </summary>
public class Triangle : Shape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    /// <summary>
    /// Конструктор треугольника - по длинам 3 его сторон
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsCorrectTriangle(sideA, sideB, sideC))
            throw new ArgumentOutOfRangeException("Incorrect values of triangle sides");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    /// <summary>
    /// Площадь треугольника
    /// </summary>
    public override double Area()
    {
        var p = (_sideA + _sideB + _sideC) / 2.0;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }

    /// <summary>
    /// Являются ли 3 длины сторон корректными для треугольника
    /// </summary>
    private static bool IsCorrectTriangle(double sideA, double sideB, double sideC)
    {
        return sideA > 0 && sideB > 0 && sideC > 0
            && sideA + sideB > sideC
            && sideA + sideC > sideB
            && sideB + sideC > sideA;
    }

    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    public bool IsRectangular()
    {
        double bigSide, side1, side2;
        if (_sideA > _sideB && _sideA > _sideC)
        {
            bigSide = _sideA; side1 = _sideB; side2 = _sideC;
        }
        else if (_sideB > _sideA && _sideB > _sideC)
        {
            bigSide = _sideB; side1 = _sideA; side2 = _sideC;
        }
        else
        {
            bigSide = _sideC; side1 = _sideA; side2 = _sideB;
        }
        return (bigSide * bigSide).IsApproximatelyEqual(side1 * side1 + side2 * side2);
    }
}
