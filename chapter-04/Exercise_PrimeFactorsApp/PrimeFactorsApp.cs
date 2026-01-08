using Exercise_PrimeFactorsLib;

PrimeFactorApp app = new();
app.App();

class PrimeFactorApp
{
    public string App()
    {
        while (true)
        {
            int number;
            string input;
            while(true)
            {
                Console.WriteLine("Pick a number between 1 & 1000: ");
                input = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Try again...");
                    continue;
                }
                if(!int.TryParse(input, out number))
                {
                    Console.WriteLine("Must be a number...");
                    continue;
                }
                if(number < 1 || number > 1000)
                {
                    Console.WriteLine("Number must be between 1 & 1000");
                    continue;
                }
                break;
            }
            string answer = PrimeFactor.PrimeFactors(number);
            Console.WriteLine($"The prime factors of {number} are {answer}");
            while(true)
            {
                Console.WriteLine("Go again? 1:YES | 2:NO" );
                input = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Try again...");
                    continue;
                }
                if(input == "1") break;
                if(input == "2") return answer;
                else
                {
                    Console.WriteLine("Must choose 1 or 2");
                    continue;
                }
            }
        }
    }
}