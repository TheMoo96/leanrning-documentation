# Abstract
## Uses
If you have an integer string of numbers that you wanna split up into each of the individual numbers, you'd use this method.

# Functionality
### [[Examples/Number Extractor]]
This program takes an input from the user via the ``int input = Convert.ToInt32(Console.ReadLine());`` line. Here we combine [[Convert.ToByte(Int16)]] and [[Console.ReadLine]] to get the input.

Once we have the input stored in ``temp`` we start a loop where ``while (temp >= 10)`` we print out the [[modulus]] of 10 from ``temp``. 
```cs
Console.WriteLine(temp % 10);
```
This essentially rips the last digit of the value.

After this we replace ``temp`` with ``temp divided by 10`` and as long as ``temp`` is ``>= 10`` we keep repeating.

Once ``temp`` temp is below 10, we output that value and the program is completed.

#### Potential improvements
```cs
while (input > 1)
{
    Console.WriteLine(input % 10);
    input /= 10;
}
```
This here will loop the extractor til it runs out of numbers, removing the need for the last exit function of pushing out a last number.

# Sources
https://stackoverflow.com/questions/17524673/understanding-the-modulus-operator