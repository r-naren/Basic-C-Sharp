using System;
namespace ForIterationStatement;
class Program
{
    public static void Main(string[] args)
    {
        // declaring variables
        int size = 10, sum = 0, average = 0;
        int[] array = new int[10];
        // getting user input values
        Console.WriteLine($"Enter the 10 numbers");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        // calculating  sum and average
        for (int i = 0; i < size; i++)
        {
            sum += array[i];
        }
        average = sum / 10;
        Console.WriteLine($"The sum of 10 number is: {sum}");
        Console.WriteLine($"The average is: {average}");
    }
}