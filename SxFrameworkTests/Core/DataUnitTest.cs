namespace SxTests.Core;

public class DataUnitTest
{
    [Fact]
    public void Test()  
    {
        Assert.Equal(DataUnit.MB, DataUnit.KB * DataUnit.KB);
        Assert.Equal(DataUnit.GB, DataUnit.MB * DataUnit.KB);
        Assert.Equal(DataUnit.TB, (long)DataUnit.GB * DataUnit.KB);
    }
}