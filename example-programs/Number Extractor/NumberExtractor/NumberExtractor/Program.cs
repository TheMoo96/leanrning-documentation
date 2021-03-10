using System;

namespace NumberExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number to be split.
            Console.Write("Enter the number you want split: ");
            //Make a variable i to hold input from user.
            //Take user input and store to i.
            int input = Convert.ToInt32(Console.ReadLine());

            //Make variable TEMP to hold i.
            int temp = input;
            //While TEMP is equal to or greater than 10.
            while (temp >= 10)
            {
                //    Print the mod10 of TEMP
                Console.WriteLine(temp % 10);
                //    Overwrite TEMP with TEMP divided by 10.
                temp = temp / 10;
            }
            //Then when TEMP is less than 10, print it.
            Console.WriteLine(temp);
            //Tell the user its done.
            Console.WriteLine("Done.");
        }
    }
}