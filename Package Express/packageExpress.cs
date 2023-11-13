using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        int weight = int.Parse(Console.ReadLine());

        // Check if weight is greater than 50
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt user for package dimensions
        Console.Write("Please enter the package width: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        int length = int.Parse(Console.ReadLine());

        // Check if dimensions total is greater than 50
        int dimensionsTotal = width + height + length;
        if (dimensionsTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate quote
        int product = width * height * length;
        decimal quote = (decimal)(product * weight) / 100;

        // Display the quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
