using Exercise_PrimeFactorsLib;

public class PrimeFactorUnitTests
{
    [Theory]
    [InlineData(50, "5x5x2")]
    [InlineData(1000, "5x5x5x2x2x2")]
    [InlineData(11, "11")]
    // [InlineData(789, "6x7")] // made to fail - now understand this is bad should be testing exceptions & other things 
    [InlineData(789, "263x3")]
    public void TestPrimeFactors(int a, string epxected)
    {
        string actual = PrimeFactor.PrimeFactors(a);
        // compare results
        Assert.Equal(epxected, actual);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1001)]
    [InlineData(-50)]
    [InlineData(-999)]
    public void TestOutOfRangeException(int a)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => PrimeFactor.PrimeFactors(a));
    }

}
