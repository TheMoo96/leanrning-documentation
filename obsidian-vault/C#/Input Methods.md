# Abstract
## Uses
If you need to get info from the user into the program.

### Multiplication program
To multiply one user defined value by another user defined value we need to somehow get that value from the user and turn it into something that can be used by the program.

# Functionality
### Multiplication program
A [[System.ReadLine]] is requested by the use of ``System.ReadLine();`` in ``Program.cs``. It is [[Convert.ToByte(Int16)]] into an int.

It is done though the following:
```cs
string input = Console.ReadLine();
int number = Convert.ToInt16(input);
```

Here it sets the variable ``string input`` to read the next line of input. Once the user presses enter, its converted into the variable ``int number``. 

If the program does this twice, it can use those int variables and multiply them together then output the result.

[[Examples/Input Methods|An example can look like this.]]