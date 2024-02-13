using System;

namespace Shapes;

public static class DoubleExtension
{
    // Допустимая точность сравнения - допускается ошибка менее 1 миллионной от сравниваемых величин
    const double COMPARISON_ACCURACY = 1e6;

    // Два числа приблизительно равны, с допустимой точностью, указанной в COMPARISON_ACCURACY
    public static bool IsApproximatelyEqual(this double a, double b)
    {
        var smallValue = Math.Min(a / COMPARISON_ACCURACY, b / COMPARISON_ACCURACY);
        var difference = Math.Abs(a - b);
        return difference < smallValue;
    }
}
