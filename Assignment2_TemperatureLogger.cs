using System;

class Program
{
    static void Main()
    {
        Console.Write("How many temperature readings? ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid number of readings.");
            return;
        }

        int[] temps = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Enter temperature {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out temps[i]))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        int sum = 0, min = temps[0], max = temps[0];
        foreach (int t in temps)
        {
            sum += t;
            if (t < min) min = t;
            if (t > max) max = t;
        }

        double avg = sum / (double)n;

        Console.WriteLine($"Min: {min}, Max: {max}, Average: {avg:F2}");

        Console.WriteLine("\nHistogram:");
        foreach (int t in temps)
        {
            Console.Write($"{t,3}: ");
            Console.WriteLine(new string('*', Math.Abs(t)));
        }
    }
}
