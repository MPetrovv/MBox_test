namespace FigureSquareCalculator.Primitives;

public class Circle : Figure
{
    /// <summary>
    /// Радиус круга
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Круг
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    /// <exception cref="ArgumentOutOfRangeException">Если радиус круга имеет отрицательное значение</exception>
    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

        Radius = radius;
    }


    /// <summary>
    /// Вычислить площадь круга
    /// </summary>
    protected sealed override double CalculateSquare()
    {
        return Math.PI * Radius * Radius;
    }
}