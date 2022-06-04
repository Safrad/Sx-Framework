using System;

namespace Sx.Math;

/// <summary>
/// Class that contains mathematical utilities.
/// </summary>
public static class DivideAndRound
{
    /// <summary>
    /// Divide and round to higher absolute number.
    /// Example:
    /// <ul>
    /// <li>-1 div 4 is -1</li>
    /// <li>0 div 4 is 0</li>
    /// <li>1 div 4 is 1</li>
    /// <li>2 div 4 is 1</li>
    /// <li>3 div 4 is 1</li>
    /// </ul>
    /// </summary>
    /// <param name="dividend">The dividend.</param>
    /// <param name="divisor">The divisor.</param>
    /// <returns>System.Int32.</returns>
    public static int AwayFromZero(int dividend, int divisor)
    {
        CheckDivisor(divisor);
        var isResultNegative = (dividend < 0) != (divisor < 0);
        var shouldRound = dividend % divisor != 0;
        return dividend / divisor + (!shouldRound ? 0 : isResultNegative ? -1 : 1);
    }

    /// <summary>
    /// Divide and round to the nearest number.
    /// Example:
    /// <ul>
    /// <li>-1 div 4 is 0</li>
    /// <li>0 div 4 is 0</li>
    /// <li>1 div 4 is 0</li>
    /// <li>2 div 4 is 1</li>
    /// <li>3 div 4 is 1</li>
    /// </ul>
    /// </summary>
    /// <param name="dividend">The dividend.</param>
    /// <param name="divisor">The divisor.</param>
    /// <returns>System.Int32.</returns>
    public static int ToNearest(int dividend, int divisor)
    {
        CheckDivisor(divisor);
        var isResultNegative = (dividend < 0) != (divisor < 0);
        if (isResultNegative)
        {
            return (dividend - (divisor / 2)) / divisor;
        }
        else
        {
            return (dividend + (divisor / 2)) / divisor;
        }
    }

    /// <summary>
    /// Determines whether is divisor correct.
    /// </summary>
    /// <param name="divisor">The divisor.</param>
    /// <returns><c>true</c> if divisor is correct; otherwise, <c>false</c>.</returns>
    private static bool IsDivisorCorrect(int divisor)
    {
        return divisor != 0;
    }

    /// <summary>
    /// Checks the divisor.
    /// </summary>
    /// <param name="divisor">The divisor.</param>
    /// <exception cref="System.ArgumentException">Divisor can not be 0.</exception>
    private static void CheckDivisor(int divisor)
    {
        if (!IsDivisorCorrect(divisor))
        {
            throw new ArgumentException("Divisor can not be 0.");
        }
    }
}
