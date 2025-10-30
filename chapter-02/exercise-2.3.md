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