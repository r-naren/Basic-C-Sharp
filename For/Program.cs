using System;
namespace For;
class Program
{
    public static void Main(string[] args)
    {
        int result = 0;
        Console.Write("Enter start range number: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter end range number: ");
        int end = Convert.ToInt32(Console.ReadLine());
        for (int inc = start+1; inc < end; inc++)
        {
            result += (inc*inc);
        }
        Console.WriteLine($"Sum of square of numbers between {start} and {end} is {result}");
             
    }
}