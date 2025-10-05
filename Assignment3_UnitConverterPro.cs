using System;

class Program
{
    static void Main()
    {
        int? lastChoice = null;

        while (true)
        {
            Console.WriteLine("\nUnit Converter Menu:");
            Console.WriteLine("1. Kilometers → Miles");
            Console.WriteLine("2. Miles → Kilometers");
            Console.WriteLine("3. Celsius → Fahrenheit");
            Console.WriteLine("4. Kilograms → Pounds");
            Console.WriteLine("5. Exit");

            if (lastChoice.HasValue)
                Console.WriteLine($"[Enter] to repeat last choice ({lastChoice.Value})");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            int choice;
            if (string.IsNullOrWhiteSpace(input) && lastChoice.HasValue)
                choice = lastChoice.Value;
            else if (!int.TryParse(input, out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            if (choice == 5) break;

            Console.Write("Enter value: ");
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                Console.WriteLine("Invalid number.");
                continue;
            }

            switch (choice)
            {
                case 1: Console.WriteLine($"{value} km = {value * 0.621371:F2} mi"); break;
                case 2: Console.WriteLine($"{value} mi = {value / 0.621371:F2} km"); break;
                case 3: Console.WriteLine($"{value} °C = {(value * 9 / 5) + 32:F2} °F"); break;
                case 4: Console.WriteLine($"{value} kg = {value * 2.20462:F2} lb"); break;
            }

            lastChoice = choice;
        }

        Console.WriteLine("Goodbye!");
    }
}
