using Exercise_PrimeFactorsLib;

public class PrimeFactorUnitTests
{
    [Theory]
    [InlineData(50, "5x5x2")]
    [InlineData(1000, "5x5x5x2x2x2")]
    [InlineData(11, "11")]
    [InlineData(789, "6x7")] // made to fail
    [InlineData(789, "263x3")]
    public void TestPrimeFactors(int a, string epxected)
    {
        string actual = PrimeFactor.PrimeFactors(a);
        // compare results
        Assert.Equal(epxected, actual);
    }
}
