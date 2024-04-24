using System;
namespace StringManipulation;
class Program{
    public static void Main(string[] args)
    {
        Console.Write($"Enter a string : ");
        string str = Console.ReadLine();
        Console.Write($"Enter a substring to search: ");
        string search = Console.ReadLine();
        string[] strArray = str.Split(search);
        Console.WriteLine($"String searched count is {strArray.Length-1}"); 
        
    }
}