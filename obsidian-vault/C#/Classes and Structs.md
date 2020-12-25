# Abstract
## Uses
When a [[client program]] needs a function done, it might be better to remove that function from the client program into its own ==class==. This offers up some advantages over having it be inside of the client program sometimes.

### Small use
Say that your client program want to know what a number is after its been multiplied by number Y. It could have that functionality exist and work within itself, or another class could be made where the functionality is called from another place. This call could contain some info, such as the number that it wants to be multiplied and it would get back the result.

### Bigger use

# Functionality
## The structure of a class
### Small use
You have a client program that needs to have the number 4 multiplied by a predetermined number. It will though a line of code send away the number 4 and then it will receive the result. This is done though two different files. ``Program.cs`` and ``Multiplier.cs``.

They both share a [[Namespace]] which allows them to communicate without declaring the [[Using|use]] of the class from ``Program.cs``.  The class of ``Multiplier.cs`` reads ``public class Multiplier``. This this means that ``Program.cs`` can call the functionality of ``Multiplier.cs`` though the prefix ``Multiplier`` in its code.

Inside of 