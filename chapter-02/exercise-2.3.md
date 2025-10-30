1. what statement can you write in c# to discover the compiler and langauge version?
    . run #error version

2. what are the two types of comments in c#
    . the single line "//" & the multi line "/**/"

3. what is the difference between a vertabrim & interpolated string?
    . interpolated string is where you use "$" in front of string & "{}" inside string for variables
    . vertabrim string is when you use "@" at beginning of string to allow for literal things like "/"

4. why should you be careful when using float & double values?
    . floats & double are stored in base 2 not base 10 / binary & decimal
    . means they have minor inaccuracies & should never be compared / "=="
    . use < <= or > >= instead

5. how can you determine how many bytes a type like double uses in memory?
    . Console.WriteLine($"double uses {sizeof(double)} bytes");

6. when should you use the var keyword?
    . only when it is obvious what the data type is to other people reading the code 

7. what is the newest syntax to create an instance of a class like XmlDocument?
    . XmlDocument xml13 = new();

8. why should you be careful when using dynamic types?
    . on dynamic types there is no inerllisence / showing built in functions etc...
    . because type is not inferred until runtime / when the Common Language Runtime find it

9. how do you right allign a format string?
    . Console.WriteLine(format: "{name,6}");
    . Name is variable name 
    . positive right align , negative left align 

10. what characters seperate arguments for a console app?
    . a space / " "

EXTRA:
what type would you choose for the following numbers?
    . 