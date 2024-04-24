using System;
namespace DoWhileLoop;
class Program{
    public static void Main(string[] args)
    {
        int number = 0;
        string option = "yes";
        bool isOption = true;
        do{
            switch(option)
            {
                case "yes":
                {
                    Console.Write($"Enter a number to check whether its odd or even : ");
            
                    number = Convert.ToInt32(Console.ReadLine());
                    if(number%2 == 0){
                        Console.WriteLine($"Even");
                    }
                    else{
                        Console.WriteLine($"Odd");
                    }
                    break;
                }
                case "no":
                {
                    isOption = false;
                    break;
                }
                default:
                {
                    Console.WriteLine($"Ener a valid input ");
                    break;         
                }
            }
            if(!isOption){
                break;
            }
            Console.Write($"Do you want to continue the program? yes/no : ");
            
            option = Console.ReadLine();
        
       }while(isOption);
    }
}
