using System;
namespace SwitchDecisionStatement;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Menu:");
        Console.WriteLine("Press 1 to add two numbers");
        Console.WriteLine("Press 2 to subtract two numbers");
        Console.WriteLine("Press 3 to multiply two numbers");
        Console.WriteLine("Press 4 to divide two numbers");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    Console.WriteLine($"Result of addition: {num1} + {num2} = {num1 + num2}");
                    break;
                }
            case 2:
                {
                    Console.WriteLine($"Result of subtraction: {num1} - {num2} = {num1 - num2}");
                    break;
                }
            case 3:
                {
                    Console.WriteLine($"Result of multiplication: {num1} * {num2} = {num1 * num2}");
                    break;
                }
            case 4:
                {
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result of division: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid choice!");
                    break;
                }
        }

    }
}