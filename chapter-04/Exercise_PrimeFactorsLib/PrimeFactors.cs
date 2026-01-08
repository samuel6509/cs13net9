using System.Text;

namespace Exercise_PrimeFactorsLib;

static class PrimeFactor
{
    // numbers < 1000
    // PRIME FACTORS OF 25
    // 2 / 25 = 50
    // 5 / 5 = 25
    // RETURN 5x5x2
    static string PrimeFactors(int n)
    {
        int current = n;
        var list = new List<string>();
        for(int i = 2; i < n; i++)
        {
            while(current % i == 0)
            {
                current /= i;
                list.Add(i.ToString());
            }
        }
        string answer = string.Join('+', list);
        Console.WriteLine(answer);
        return answer;
    }
}
