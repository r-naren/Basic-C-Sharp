using System;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
namespace Method;
class Program
{
    public static void Main(string[] args)
    {
        string option = "yes";
        do
        {
            if (option == "yes")
            {

                Calulation();
                Console.WriteLine("Do you wish to continue yes/no");
                option = Console.ReadLine();

            }
        } while (!(option == "no"));
    }
    public static double Addition(double num1, double num2)
    {
        return num1 + num2;
    }
    public static double Subtraction(double num1, double num2)
    {
        return num1 - num2;
    }
    public static double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }
    public static double Division(double num1, double num2)
    {
        return num1 / num2;
    }
    public static void Calulation()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        switch (ch)
        {
            case '+':
                {
                    Console.WriteLine(Addition(num1, num2));
                    break;
                }
            case '-':
                {
                    Console.WriteLine(Subtraction(num1, num2));
                    break;
                }
            case '*':
                {
                    Console.WriteLine(Multiplication(num1, num2));
                    break;
                }
            case '/':
                {
                    Console.WriteLine(Division(num1, num2));
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid opertor");
                    break;
                }
        }
    }
}