using System;
namespace OperatorsExpressionsAndStatementsQ1;
class Program
{
    public static void Main(string[] args)
    {
        // Getting input
        Console.Write($"Enter number 1 : ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write($"Enter number 2 : ");
        double number2 = double.Parse(Console.ReadLine());
        //doing operations
        Console.WriteLine($"Addition : {Addition(number1, number2)}");
        Console.WriteLine($"Subtraction : {Subtraction(number1, number2)}");
        Console.WriteLine($"Multiplication : {Multiplication(number1, number2)}");
        Console.WriteLine($"Division : {Division(number1, number2)}");
        Console.WriteLine($"Modulus : {Modulus(number1, number2)}");


    }
    //Methods
    public static double Addition(double number1, double number2)
    {
        return number1 + number2;
    }
    public static double Subtraction(double number1, double number2)
    {
        return number1 - number2;
    }
    public static double Multiplication(double number1, double number2)
    {
        return number1 * number2;
    }
    public static double Division(double number1, double number2)
    {
        return number1 / number2;
    }
    public static double Modulus(double number1, double number2)
    {
        return number1 % number2;
    }
}