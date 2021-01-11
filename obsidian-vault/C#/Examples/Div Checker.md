```cs
	using System;

namespace Div_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user which value to start counting down from. 
            Console.Write("Input number to start counting down from: ");
            //Read the value and store it in INPUT.
            int input = Convert.ToInt32(Console.ReadLine());
            //Start a for loop that counts down from INPUT to 0.
            for (int i = input; i > 10; i--)
            {
                //##(Every loop it will take the value and disect it into the individual numbers and check if the loop variable is divisible by them.)
                //Create an int variable that is the current loop number.
                int copy = i;
                //##Check if the loop number is divisible by the mod10 of the copy.
                //If the loop number is divisible by the mod10 of the copy, and copy isnt 0.
                while (copy % 10 != 0 && i % (copy % 10) == 0)
                {
                    //    Divide the copy by 10.
                    copy /= 10;
                    //    If the copy is less than 1.
                    if (copy < 1)
                    {
                        //        Print the loop number.
                        //        Ask user to press any button to continue
                        Console.WriteLine($"{i} is a magic number. \n Press any button to continue looking.");
                        //        Await input.
                        Console.ReadKey();
                        //        Break.
                        // break; // No need to break?
                    }
                }
            }
        }
    }
}

```

Compacted version
```cs
using System;

namespace Div_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number to start counting down from: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = input; i > 10; i--)
            {
                int copy = i;
                while (copy % 10 != 0 && i % (copy % 10) == 0)
                {
                    copy /= 10;
                    if (copy < 1)
                    {
                        Console.WriteLine($"{i} is a magic number. \n Press any button to continue looking.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
```