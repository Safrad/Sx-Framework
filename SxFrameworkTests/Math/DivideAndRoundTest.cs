namespace SxTests.Math;

public class DivideAndRoundTest
{
    [Theory]
    [InlineData(-1, 4, -1)]
    [InlineData(0, 4, 0)]
    [InlineData(1, 4, 1)]
    [InlineData(2, 4, 1)]
    [InlineData(3, 4, 1)]
    public void DivideAndRoundAwayFromZeroTest(int divident, int divisor, int result)
    {
        Assert.Equal(result, DivideAndRound.AwayFromZero(divident, divisor));
    }

    [Theory]
    [InlineData(-1, 4, 0)]
    [InlineData(0, 4, 0)]
    [InlineData(1, 4, 0)]
    [InlineData(2, 4, 1)]
    [InlineData(3, 4, 1)]
    public void DivideAndRoundToNearestTest(int divident, int divisor, int result)
    {
        Assert.Equal(result, DivideAndRound.ToNearest(divident, divisor));
    }

    [Fact]
    public void ArgumentExceptionTest()
    {
        Assert.Throws<ArgumentException>(() => DivideAndRound.ToNearest(7, 0));
    }    
}
