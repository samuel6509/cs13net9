// OverFlow();
// FizzBuzz();
HandleExceptionsUserInput();

// function for catching an overflow of a byte in a for loop
void OverFlow()
{
    // when executing this code it counts to 255 which is the max of bytes then resets
    // int max = 500;
    // for(byte i = 0; i < max; i++)
    // { 
    //     Console.WriteLine(i);
    // }

    // this works 
    int max = 500;
    // see if exception is found
    try
    {
        // detects arithmetic overflows
        // usually silently wraps around to the beginning number again
        checked
        {
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    // catch an overflow exception
    catch (OverflowException e)
    {
        Console.WriteLine($"OVERFLOW EXPECTION CAUGHT: {e}");
    }
}

// function for implementing the childs game fizzbuzz
// divisible by 3 & 5 fizzbuzz
// divisible by 3 fizz
// divisible by 5 buzz
// neither return number
void FizzBuzz()
{
    // can change this easily in for loop without, easier for other ppl to use this
    int max = 100;
    List<string> answer = new List<string>();
    for (int i = 1; i <= max; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            answer.Add("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            answer.Add("Fizz");
        }
        else if (i % 5 == 0)
        {
            answer.Add("Buzz");
        }
        else
        {
            answer.Add($"{i}");
        }
    }
    // prints each item of list in a single string spaced with comma + space
    Console.WriteLine(string.Join(", ", answer));
}

// user gives 2 numbers between 0 & 255
// divide first number by second number
// point is to handle any excpections that can be raised
void HandleExceptionsUserInput()
{
    int firstInput = 0;
    int secondInput = 0;

    Console.Write("Enter a number between 0 & 255: ");
    try
    {
        firstInput = int.Parse(Console.ReadLine().Replace(" ", ""));
        if(firstInput < 0 || firstInput > 255)
        {
            Console.WriteLine("NUMBER MUST BE BETWEEN 0 & 255!");
            return;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine($"FORMAT EXCEPTION CAUGHT: {e}");
    }

    Console.Write("Enter another number between 0 & 255: ");
    try
    {
        secondInput = int.Parse(Console.ReadLine().Replace(" ", " "));
        if(secondInput < 0 || secondInput > 255)
        {
            Console.WriteLine("NUMBER MUST BE BETWEEN 0 & 255!");
            return;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine($"FORMAT EXCEPTION CAUGHT: {e}");
    }

    try
    {
        Console.WriteLine($"{firstInput} divided by by {secondInput} is {firstInput / secondInput}");
    }
    catch(DivideByZeroException e)
    {
        Console.WriteLine($"DIVIDE BY ZERO EXCEPTION CAUGHT: {e}");
    }
}