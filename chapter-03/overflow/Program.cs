// OverFlow();
FizzBuzz();

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