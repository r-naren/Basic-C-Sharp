using System;
using System.Data.SqlTypes;
using System.Linq;
namespace WorkingWithStringsQ1;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write($"Input string : ");

        string str = Console.ReadLine();
        Console.WriteLine($"Odd number of characters from input string");

        for (int i = 0; i < str.Length; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write($"{str[i]}");
            }
        }
        str = str.Replace('n', 'N');
        Console.WriteLine($"\nReverse string ");
        char[] charArr = str.ToCharArray();
        Array.Reverse(charArr);
        string revStr = new string(charArr);
        Console.WriteLine($"{revStr}");

        Console.WriteLine($"Length of the string is {revStr.Length}");
        Console.Write($"Enter First string : ");
        string firstStr = Console.ReadLine();
        Console.Write($"Enter Second string : ");
        string secondStr = Console.ReadLine();
        string newStr = "";
        for (int i = 0; i < 4; i++)
        {
            newStr += firstStr[i];
        }
        for (int i = secondStr.Length - 3; i < secondStr.Length; i++)
        {
            newStr += secondStr[i];
        }
        Console.WriteLine($"Output : {newStr}");
        string cities = "Chennai,Trichy,Mumbai";
        string[] strArr = cities.Split(",");
        Console.WriteLine($"Printing cities in separate line");
        
        for (int i = 0; i < strArr.Length; i++)
        {
            Console.WriteLine($"{i + 1}.{strArr[i]}");

        }
    }
}