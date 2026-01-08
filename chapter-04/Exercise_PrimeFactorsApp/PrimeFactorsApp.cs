using Exercise_PrimeFactorsLib;

PrimeFactorApp app = new();
app.App();

class PrimeFactorApp
{
    public string App()
    {
        int number;
        while(true)
        {
            Console.Write("Pick a number between 1 & 1000: ");
            string input = Console.ReadLine();
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
        return "";
    }
}