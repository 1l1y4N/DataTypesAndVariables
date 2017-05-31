using System;


namespace P7Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var surname = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {name} {surname}. You are {age} years old.");
        }
    }
}
