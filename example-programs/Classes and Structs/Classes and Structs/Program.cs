using System;

namespace Classes_and_Structs
{
    public class ClassPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ClassPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
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
    class ClassProgram
    {
        static void Main()
        {
            // This uses a class.
            ClassPerson person1 = new ClassPerson("Leo", 8);
            Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}.");

            ClassPerson person2 = person1;

            person2.Name = "Molly";
            person2.Age = 29;

            Console.WriteLine($"person2 Name = {person2.Name} Age = {person2.Age}.");
            Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}.");

            Console.WriteLine();

            // This uses a struct.
            StructPerson person3 = new StructPerson("John", 3);
            Console.WriteLine($"person3 Name = {person3.Name} Age = {person3.Age}.");

            StructPerson person4 = person3;
            person4.Name = "Doris";
            person4.Age = 90;

            Console.WriteLine($"person4 Name = {person4.Name} Age = {person4.Age}.");
            Console.WriteLine($"person3 Name = {person3.Name} Age = {person3.Age}.");
        }
    }
}
