using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        bool isPresent = false;
        Console.Write($"Enter size of the array : ");
        int size = int.Parse(Console.ReadLine());

        string[] names = new string[size];
        Console.WriteLine($"Enter the names : ");

        for (int i = 0; i < size; i++)
        {
            names[i] = Console.ReadLine();
        }
        Console.WriteLine($"The names are : ");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.Write($"Enter a name to search : ");

        string searchName = Console.ReadLine();
        for (int i = 0; i < size; i++)
        {
            if (searchName == names[i])
            {
                Console.WriteLine($"The name is present in array and its index is {i}");
                isPresent = true;
            }
        }
        if (!isPresent)
        {
            Console.WriteLine($"The name is not present in array");
        }
        isPresent = false;
        foreach (string name in names)
        {
            if (searchName == name)
            {
                Console.WriteLine($"The name is present in array");
                isPresent = true;
                break;
            }
        }
        if (!isPresent)
        {
            Console.WriteLine($"The name is not present in array");

        }
    

    }
}