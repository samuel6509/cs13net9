namespace Exercise_PrimeFactorsTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        PrimeFactor prime = new();
        var answer = prime.PrimeFactor();
    }
}
