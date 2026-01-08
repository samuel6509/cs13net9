namespace Exercise_PrimeFactorsLib;

public static class PrimeFactor
{
    // numbers < 1000
    // PRIME FACTORS OF 25
    // 2 / 25 = 50
    // 5 / 5 = 25
    // RETURN 5x5x2
    public static string PrimeFactors(int n)
    {
        if(n < 1 || n > 1000) throw new ArgumentOutOfRangeException(nameof(n), "number must be between 1 & 1000");
        
        int current = n;
        var list = new List<int>();
        for(int i = 2; i <= n; i++)
        {
            while(current % i == 0)
            {
                current /= i;
                list.Add(i);
            }
        }
        list.Sort();
        list.Reverse();
        string answer = string.Join('x', list);
        Console.WriteLine(answer);
        return answer;
    }
}