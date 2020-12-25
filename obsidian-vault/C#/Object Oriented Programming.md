# Abstract
## Big picture
You want to create some profiles for a few people and they should all have the same structure, this would be the job for a ==Class or Struct==. A class or struct is like a base blueprint that can be instanced. These instances are called ==Objects==. Each object of a class can have different values, while still working in the same way as the other objects of that class. This eliminates the need for repeated code.

### Object [^object]
An object is a block of memory allocated to hold information determined by the class or struct its made from. Several different objects can be created in the same program from the same class or struct. These objects are stored within variables, or in an array. Bigger programs usually have many different objects all interacting with each-other.

### Class [^class]
"A class is a reference type." If you create an object off a class, it just references to that class. Meaning that if you create a new object based off the original then any changes made to one is reflected on the other.

### Struct [^class]
"A struct is a value type." If you create an object from a struct, that object now holds the actual data of the struct. Meaning that if you create another object based off that struct, it becomes a copy of the original object. Any changes you make to one will not be reflected on the other.

### Basically...
If an object is created from a class, that object is basically a window to that class on which you write your variables. If you then create another object and base it on the previous one, the second one will be looking at the first one who is looking at some allocated space. Since they're both looking at the same allocated space, they will both be drawing on the same figurative window.

Meanwhile if you create an object based off a struct, that object copies the entire struct and puts its own info on that copy. So if you then make another object based on the first object, that second object will also make a copy and use that to store its own shit on.

There's some memory management that makes the two have different use cases.

# Functionality
## Big Picture
Following [[Classes and Structs]].
### Creating Class
```cs
public class ClassPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public ClassPerson(string name, int age)
    {
        Name = name;
        Age = age;
    }
```
This block of code creates a public class named ``ClassPerson``. Inside of which it defines what that class actually is. This specific one takes two pieces of info when an object is created with it. A name in the form of a string, and the age in the form of an int.

More information on the creation of a class can be found ==here==.

### Creating a struct
```cs
public struct StructPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public StructPerson(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
```
This block does the same thing, but calls the struct ``StructPerson``. The creation is the same.

### Using Class
```cs
ClassPerson person1 = new ClassPerson("Leo", 8);
Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}.");
```
Inside of the Main program, it calls ``ClassPerson`` to create a new object called ``person1``. It creates it off a ``new`` ClassPerson with the info inside of the parentheses as the previously created class stated. That is then output though the console and the result will be: 
> person1 Name = Leo Age 8.

---
```cs
ClassPerson person2 = person1;
person2.Name = "Molly";
person2.Age = 29;
```
We then create another object called ``person2`` from ``person1``, after which we change its name and age as shown. As this was done to ``person1`` which is based off a class and is a therefore a reference type, we are now overwriting the data stored on ``person1``.

---
```cs
Console.WriteLine($"person2 Name = {person2.Name} Age = {person2.Age}.");
Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}.");
```
We now output the name and age of ``person2`` as well as ``person1`` and we see the output being the same as we overwrote the data of ``person1``.
The results will be: 
> person2 Name = Molly Age = 29
> person1 Name = Molly Age = 29


### Using Struct
```cs
StructPerson person3 = new StructPerson("John", 3);
Console.WriteLine($"person3 Name = {person3.Name} Age = {person3.Age}.");
```
This creates, just like the class, a new object from the struct ``Struct Person`` called ``person3``. The output from this will be:
> person3 Name = John Age = 3.

---
```cs
StructPerson person4 = person3;
person4.Name = "Doris";
person4.Age = 90;
```
We then create another object from ``person3`` and call it ``person4``, after which we change the name and age as shown. Since ``person3`` is based off a struct and is therefore a value type, we have now created a **copy**. Any changes to ``person4`` will not be translated to ``person3``.

---
```cs
Console.WriteLine($"person4 Name = {person4.Name} Age = {person4.Age}.");
Console.WriteLine($"person3 Name = {person3.Name} Age = {person3.Age}.");
```
As we now output the two objects we can see that the data on ``person3`` has remained intact.
The result will be:
> person4 Name = Doris Age = 90.
> person3 Name = John Age = 3.

# Sources
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/

[^object]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/objects
[^class]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes
