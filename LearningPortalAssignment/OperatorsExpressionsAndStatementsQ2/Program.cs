using System;
namespace OperatorsExpressionsAndStatementsQ2;
class Program
{
    public static void Main(string[] args)
    {
        // getting 3 values fro users
        Console.Write($"Enter number 1 : ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write($"Enter number 2 : ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write($"Enter number 3 : ");
        int number3 = int.Parse(Console.ReadLine());
        // finding largest of 3 numbers
        if (number1 >= number2)
        {
            if (number1 >= number3)
            {
                Console.WriteLine($"Number1 {number1} is greater");
            }
            else
            {
                Console.WriteLine($"Number3 {number3} is greater");
            }
        }
        else
        {
            if (number2 >= number3)
            {
                Console.WriteLine($"Number2 {number2} is greater");
            }
            else
            {
                Console.WriteLine($"Number3 {number3} is greater");
            }
        }
    }
}