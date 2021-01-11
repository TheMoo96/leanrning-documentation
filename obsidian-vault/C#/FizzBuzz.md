# Abstract
## Program Explanation
The program goes through numbers 1-100. Each number is checked to see if it is either:
- Divisible by 3, then replacing the output with "Fizz"
- Divisible by 5, then replacing the output with "Buzz"
- Divisible by 3 *and* 5, then replacing the output with "FizzBuzz!"

It outputs all the numbers in sequence following these rules. 

# Ways to do it
## [[FizzBuzz!#Moo Version|My Version]]
### Code Explanation
The code runs a [[for loop]] with ``int i`` going from 1 to 100. 
Each loop it checks through an ``if, else if`` list to find if ``i`` is divisible by 3 and 5, or 3, or 5, in that order, and prints the corresponding response. 
The FizzBuzz possibility must be at the top as having it below Fizz would mean that the Fizz possibility wold get detected first and break out the 'if, else if' list. If none of these are true then it prints the number instead. 
It prints a new line and the 'for loop' continues. 

### Criticism
- The program will be exponentially harder to expand. The move from 2 conditions to 3 conditions will add one solo, two versions of the double, and a new triple, for a total of 4 new entries. 
	- With 4 conditions you'd now have to add one solo, three versions of the double, three versions of the triple case, and a new quad, for a total of 8 new entries. 
EX on 3 cases:  
```cs
if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)	// New Tripple Class
	Console.Write("FizzBuzzWizz!!")
else if (i % 3 == 0 && i % 5 == 0)
    Console.Write("FizzBuzz!");
else if (i % 3 == 0 && i % 7 == 0)		// Two Extra Doubles
	Console.Write("FizzWizz!");			//
else if (i % 5 == 0 && i % 7 == 0)		//
	Console.Write("BuzzWizz!");			//
else if (i % 3 == 0)
    Console.Write("Fizz");
else if (i % 5 == 0)
   Console.Write("Buzz");
else if (i % 7 == 0)				// One Extra Solo
	Console.Write("Wizz");			//
else
     Console.Write(i);
Console.WriteLine();
```

## [[FizzBuzz!#Coen van Dam|Coen's Version]]
### Abstract
The code counts from 1 to 100. At the start of every loop it initializes the string ``tempString`` to ``null``.  After this it starts by checking if the loop variable ``i`` is divisible by 3, which if it is it adds the string ``Fizz`` to ``tempString``. It does the same for Buzz. Once it has done this it then uses a null-coalescing operator^[https://docs.microsoft.com/en-in/dotnet/csharp/language-reference/operators/null-coalescing-operator] (``??``) to check if ``tempString`` is null. If it is then it will print ``i`` as a string, if it isn't then it will print whatever is contained within ``tempString``. At the start of the next loop the contents of ``tempString`` is returned to null.

### Criticism
The problems mentioned [[FizzBuzz#Criticism|earlier]] in Moo's version where expanding the program to include more states is here completely negated. As each if statement is contained by itself and one being true just throws the result into a string that gets printed at the end. There's no "if Fizz and Buzz, print FizzBuzz", so there's no exponentially expanding list of things to add. You would simply just add:
```cs
if (i % 7 == 0)
	tempString += "Wizz";
```
and it would be integrated by itself.

Do note that the order of the if statements rule in what order that things show up. Reversing it would for example show BuzzFizz instead.

## [[FizzBuzz!#Internet Stranger]]
### Abstract
The code runs from 1 to 100 though int ``i``. On every loop it initiates two booleans. One for Fizz and one for Buzz. This stores Fizz as either true for ``i`` or false. Same for Buzz. It then runs though an ``if, else if`` list to see what combination of the two booleans is true. If nothing is true then it prints the number.

### Criticism
The use of booleans is cool, as it could potentially take up less memory with a simple true or false statement. But as it creates multiple ones this might be negated. It also runs into the same [[FizzBuzz#Criticism|expandability]] issue that Moo's version has, but in a slightly more efficient way as the logic is contained in the boolean. Still, expandability is an issue.


# Sources
https://stackoverflow.com/a/11764613 <- Internet Stranger Code.
https://stackoverflow.com/questions/446835/what-do-two-question-marks-together-mean-in-c