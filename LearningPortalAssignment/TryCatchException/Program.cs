using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result;
            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine($"Result of division: {num1} / {num2} = {result}");
            }
            else
            {
                throw new DivideByZeroException();
            }

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
