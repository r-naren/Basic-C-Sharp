using System;
namespace Switch;
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number 1 : ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            double number2 = double.Parse(Console.ReadLine());
            Console.Write("Enter any of these 5 options \n +, -, *, /, % : ");
            char option = char.Parse(Console.ReadLine());
            switch(option){
                case '+':
                {
                    Console.WriteLine(number1+number2);
                    break;
                }
                case '-':
                {
                    Console.WriteLine(number1-number2);
                    break;
                }
                case '*':
                {
                    Console.WriteLine(number1*number2);
                    break;
                }
                case '/':
                {
                    Console.WriteLine(number1/number2);
                    break;
                }
                case '%':
                {
                    Console.WriteLine(number1%number2);
                    break;
                }
                default:
                {
                    Console.WriteLine("Operation is invalid");
                    break;
                }
            }
            
            
        }
    }
