using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your first name: ");
        string first = Console.ReadLine()?.Trim();

        Console.Write("Enter your last name: ");
        string last = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last))
        {
            Console.WriteLine("Error: First and last name cannot be empty.");
            return;
        }

        char firstInitial = char.ToUpperInvariant(first[0]);
        char lastInitial = char.ToUpperInvariant(last[0]);

        Console.WriteLine($"Hello, {first} {last} ({firstInitial}.{lastInitial}.)");
    }
}
