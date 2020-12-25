# Abstract
## Uses
To read a line from the user in the console.

### Multiplication program
To multiply one user defined value by another user defined value, we use  ``System.ReadLine();`` to get the values. 

# Functionality
### [[Input Methods#Multiplication program|Multiplication program]]
An input is requested by the use of ``System.ReadLine();`` in ``Program.cs``. It seems that the input is handled in the way of a ``string``.  To get it into an ``int`` its sent through [[Convert.ToByte(Int16)]].

The code inside of ``Program.cs`` looks like this:
```cs
Console.Write("       Enter int:");
string input = Console.ReadLine();
```

Though this it sets the input of the user to the string ``input``.

# Sources
https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-5.0

Better example:
https://docs.microsoft.com/en-us/dotnet/api/system.console.read?view=net-5.0#examples