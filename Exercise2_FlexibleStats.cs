using System;

class Program
{
    static void Main()
    {
        int count = 0, sum = 0, number;
        int min = 0, max = 0;
        bool firstInput = true;

        while (true)
        {
            Console.Write("Enter a whole number (blank to finish): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            if (int.TryParse(input, out number))
            {
                count++;
                sum += number;

                if (firstInput)
                {
                    min = max = number;
                    firstInput = false;
                }
                else
                {
                    if (number < min) min = number;
                    if (number > max) max = number;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        if (count > 0)
        {
            double avg = sum / (double)count;
            Console.WriteLine($"Count: {count}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average: {avg:F2}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}
