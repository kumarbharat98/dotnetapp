using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid integer numbers.");
        }
    }
}
