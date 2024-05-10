using System;
using System.Data.Common;
namespace DateAndTime;
class Program{
    public static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        Console.WriteLine($"Current month of the day : {today.Month}");
        today = today.AddDays(-3);
        Console.WriteLine($"Previous of 3 days from today : {today.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"12 hours time format : {today.ToString("hh:mm:ss tt")}");
        
    }
}