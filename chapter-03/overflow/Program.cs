OverFlow();

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