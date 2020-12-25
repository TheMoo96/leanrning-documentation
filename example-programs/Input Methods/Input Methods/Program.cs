using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want multiplied?");
            Console.Write("       Enter int:");
            string input = Console.ReadLine();

            Console.WriteLine($"By what do you want to muliply {input} with?");
            Console.Write("       Enter int:");
            string input2 = Console.ReadLine();


            int number = Convert.ToInt16(input);
            int number2 = Convert.ToInt16(input2);

            int result = number * number2;

            Console.WriteLine($"The result is {result}");
        }
    }
}
