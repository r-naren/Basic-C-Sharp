using System;
using System.Collections.Generic;
using System.Linq;
namespace WorkingithLINQQ1AndQ2;
class Program {
    public static void Main(string[] args)
    {
        string[] stringsArray = {"ABU DHABI","AMSTERDAM","ROME","MADURAI","LONDON","NEW DELHI","MUMBAI","NAIROBI"};
        char startChar = 'M';

        char endChar = 'I';
        IEnumerable<string> results = stringsArray.Where(str =>
            str.Length >= 2 &&
            str[0] == startChar &&
            str[str.Length - 1] == endChar);
        string result = string.Join(", ", results);
        if (result != null)
        {
            Console.WriteLine("String starting with '" + startChar + "' and ending with '" + endChar + "':");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No string found starting with '" + startChar + "' and ending with '" + endChar + "'.");
        }
        var sortedArray = stringsArray.OrderBy(item => item.Length).ThenBy(item => item);

        // Display the sorted array
        Console.WriteLine("\nSorted array by length of string and then by name in ascending order:");
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }

    }

}