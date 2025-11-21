// OverFlow();
FizzBuzz();
// HandleExceptionsUserInput();
// DividingByZero();
// KnowledgeOfOperators();

// trying something out for exercise 3.3 question 8
// turns out its an infinite loop
// for (; ; );

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
        if (i % 3 == 0 && i % 5 == 0) answer.Add("FizzBuzz");
        else if (i % 3 == 0) answer.Add("Fizz");
        else if (i % 5 == 0) answer.Add("Buzz");
        else answer.Add($"{i}");
    }
    // prints each item of list in a single string spaced with comma + space
    // foreach(string s in answer) Console.Write(s);
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
        // read user input, parse as int & replace white space with no space
        firstInput = int.Parse(Console.ReadLine().Replace(" ", ""));
        // not exception handling but neccessary error handling
        if (firstInput < 0 || firstInput > 255)
        {
            Console.WriteLine("NUMBER MUST BE BETWEEN 0 & 255!");
            return;
        }
    }
    // if there is no int or the string cannot be converted cleanly to int
    catch (FormatException e)
    {
        Console.WriteLine($"FORMAT EXCEPTION CAUGHT: {e}");
    }

    Console.Write("Enter another number between 0 & 255: ");
    try
    {
        secondInput = int.Parse(Console.ReadLine().Replace(" ", " "));
        if (secondInput < 0 || secondInput > 255)
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
    // if zero is the second number given
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"DIVIDE BY ZERO EXCEPTION CAUGHT: {e}");
    }
}

// function to divide a double by zero to see if it works
void DividingByZero()
{
    double one = 10;
    double two = 0;

    try
    {
        Console.WriteLine($"ten divided by zero equals {one / two}");
    }
    // idk if this will work so...
    catch (Exception e)
    {
        Console.WriteLine($"EXCEPTION CAUGHT: {e}");
    }
    // I now see it always returns 8 which is infinity upwards
}

// function testing operators
// seeing if i can pretict what happens correctly
void KnowledgeOfOperators()
{
    // one is going to stay the same 
    int one = 3;
    Console.WriteLine(one);
    // one did indeed stay the same 

    // two is going to equal 6
    int two = 2 + ++one;
    Console.WriteLine(two);
    // it did equal 6
    Console.WriteLine();

    // this will be 12
    // 0011 becomes 1100 which is 12
    int three = 3 << 2;
    Console.WriteLine(three);
    // it was 12

    // this will be 5
    // 1010 becomes 0101 which is 5
    int four = 10 >> 1;
    Console.WriteLine(four);
    // it was 5
    Console.WriteLine();

    // five will equal 8 / BITWISE AND 
    // 1010 AND 1000 == 1000 WHICH IS 8
    int five = 10 & 8;
    Console.WriteLine(five);
    // equals 8

    // six will equal 15 / BITWISE OR (NOT XOR / EXCLUSIVE OR)
    // 1010 OR 0111 == 1111 WHICH IS 15
    int six = 10 | 7;
    Console.WriteLine(six);
    // equals 15
    Console.WriteLine();
}