namespace MathLibrary;

/// <summary>
/// Performs basic floating point operations including precision comparison
/// </summary>
/// <param name="precision"></param>
public class BasicFloatingPointOperations(int precision = 8)
{
    /// <summary>
    /// Precision to use when comparing two floating point numbers
    /// </summary>
    private readonly int _precision = precision;

    /// <summary>
    ///  Adds two floating point numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>double</returns>
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    ///  Subtracts two floating point numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>double</returns>
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    ///  Multiplies two floating point numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>double</returns>
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    ///  Divides two floating point numbers. Returns infinity if denominator is zero.
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    /// <returns></returns>
    public double Divide(double numerator, double denominator)
    {
        return numerator / denominator;
    }

    /// <summary>
    ///   Returns true if the two values are equal within the specified precision
    /// </summary>
    /// <param name="a">1st value to compare</param>
    /// <param name="b">2nd value to compare</param>
    /// <returns>bool</returns>
    public bool Equals(double a, double b)
    {
        var tolerance = Math.Pow(10, -_precision);
        var absoluteValueOfDiff = Math.Abs(a - b);
        var isWithinTolerance = absoluteValueOfDiff <= tolerance;
        return isWithinTolerance;
    }

    /// <summary>
    ///  Returns a string stating whether a is equal to b, greater than b, or less than b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>string</returns>
    public string GetEqualityLabel(double a, double b)
    {
        return Equals(a, b)
            ? $"{a} equals {b}"
            : a > b
                ? $"{a} is greater than {b}"
                : $"{a} is less than {b}";
    }
}
