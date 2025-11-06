1. What happens when you divide an int variable by 0?
    . if you divide an int variable by 0 then DivideByZero exception will be raised

2. What happens when you divide a double variable by 0?
    . it returns 8, which is the infinity sign upwards

3. What happens when you overflow an int variable that is set to a value beyond its range?
    . it becomes negative & starts decrementing 

4. What is the difference between x = y++; and x = ++y;
    . y++ increments at the end of block / condition
    . ++y increments at the start of block / condition

5. what is the difference between break, continue & return in a loop statement?
    . break is used to exit out of a loop
    . continue misses its current iteration of a loop and continues
    . return exits out of everything (in current context the console app)

6. what are the three parts of a for statement & which of them are required?
    . OPTIONAL initializer expression / int i = 0;
    . OPTIONAL conditional expression / i < 10;
    . OPTIONAL iterator expression / i++;
    . all are optional 

7. what is the difference between = & == operators
    . = is used to assign a value to a variable
    . == is used to compare if two things are equal / the same 

8. does the following statement compile? for (;;;) ; 
    . i wouldnt expect it to because it is missing the opening and closing brakcets for initialising for loop but i will try now...
    . turns out it does compile & it is just an infite loop

9. what does the underscore (_) represent in a switch statement?
    . its the newer and easier way for the default keyword

10. what interface must an object implement to be enumerated over by using a foreach statement?
    . System.Collections.IEnumerable