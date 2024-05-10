using System;
namespace IfDecisionStatement;
class Program
{
    public static void Main(string[] args)
    {
        // getting grade from user
        Console.Write($"Enter your Grade : ");
        char grade = char.Parse(Console.ReadLine());
        //Printing according to user inputed values
        if (grade == 'A')
        {
            Console.WriteLine($"Grade A denotes 9 Points");
        }
        else if (grade == 'B')
        {
            Console.WriteLine($"Grade B denotes 8 Points");
        }
        else if (grade == 'C')
        {
            Console.WriteLine($"Grade C denotes 7 Points");

        }
        else if (grade == 'D')
        {
            Console.WriteLine($"Grade D denotes 6 Points");

        }
        else
        {
            Console.WriteLine($"This is not valid Grade.");

        }
    }
}