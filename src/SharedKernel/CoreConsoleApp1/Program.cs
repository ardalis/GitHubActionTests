using System;

namespace CoreConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "Steve" };

            Console.WriteLine($"Hello {person.Name} ({person.Id}) from .NET Core");

            Console.ReadLine();

        }
    }
}
