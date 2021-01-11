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
Each loop it checks through an [[if, else if]] list to find if ``i`` is divisible by 3 and 5, or 3, or 5, in that order, and prints the corresponding response. 
The FizzBuzz possibility must be at the top as having it below Fizz would mean that the Fizz possibility wold get detected first and break out the 'if, else if' list. If none of these are true then it prints the number instead. 
It prints a new line and the 'for loop' continues. 

### Potential improvements. 
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
The code 

# Sources