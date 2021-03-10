# 

## Moo Version
```cs
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz!");
                else if (i % 3 == 0)
                    Console.Write("Fizz");
                else if (i % 5 == 0)
                    Console.Write("Buzz");
                else
                    Console.Write(i);
                Console.WriteLine();
            }
        }
    }
}
```

## Coen van Dam
```cs
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string tempString = null;
                if (i % 3 == 0)
                {
                    tempString += "Fizz";
                }

                if (i % 5 == 0)
                {
                    tempString += "Buzz";
                }

                Console.WriteLine(tempString ?? i.ToString());
            }
        }
    }
}
```

## Internet Stranger
```cs
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
```