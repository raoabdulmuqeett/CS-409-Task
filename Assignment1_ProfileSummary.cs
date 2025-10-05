using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()?.Trim();

        Console.Write("Enter your age: ");
        string ageText = Console.ReadLine();

        Console.Write("Enter your city: ");
        string city = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(city) ||
            !int.TryParse(ageText, out int age) || age < 0 || age > 120)
        {
            Console.WriteLine("Invalid input. Please try again.");
            return;
        }

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"City: {city}");
    }
}
