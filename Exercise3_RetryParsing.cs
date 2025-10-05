using System;

class Program
{
    static void Main()
    {
        int attempts = 0, maxAttempts = 3;
        int number;

        while (attempts < maxAttempts)
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                Console.WriteLine($"You entered: {number}");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine($"Invalid input. Attempts left: {maxAttempts - attempts}");
            }
        }

        Console.WriteLine("Too many invalid attempts. Goodbye!");
    }
}
