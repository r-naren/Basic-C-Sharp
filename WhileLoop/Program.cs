using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        int inc = 0;
        int number;
        //Question 1
        Console.WriteLine("Exercise 1 : ");
        
        while(inc<25)
        {
            if( inc%2 == 0 )
            {
                Console.WriteLine(inc);
            }
            inc +=2;
        }
        //Question 2
        Console.WriteLine("Exercise 2 : ");
        Console.Write("Enter a number : ");
        bool isValid = int.TryParse(Console.ReadLine(),out number);
        while(!isValid){
            Console.Write("Invalid input format. Please enter the input in number format : ");
            isValid = int.TryParse(Console.ReadLine(),out number);
        }
        Console.WriteLine($"{number}");
        

    }
}
