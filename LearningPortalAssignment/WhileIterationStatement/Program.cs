using System;
namespace WhileIterationStatement;
class Program{
    public static void Main(string[] args)
    {
        int choice = 0;
        char isContinue = 'Y';
        bool temp=false;
        while(isContinue=='Y'){
            Console.WriteLine($"Which city is capital of India?");
            Console.WriteLine($"\t1.Chennai\n\t2.Delhi\n\t3.Mumbai\n\t4.Kolkata");
            Console.Write($"Enter your choice: ");
            temp = int.TryParse(Console.ReadLine(), out choice);
            while(!temp || choice>4 || choice<1)
            {
                Console.Write($"Enter valid choice from 1 to 4: ");
                temp = int.TryParse(Console.ReadLine(), out choice);
            }
            if(choice==2)
            {
                Console.WriteLine($"Correct..");
                isContinue='N';
            }
            else
            {
                Console.WriteLine($"Incorrect!");
                Console.WriteLine($"Press Y to continue, Press N to close");
                temp = char.TryParse(Console.ReadLine(), out isContinue);
                while(!temp || !(isContinue=='Y' || isContinue=='N'))
                {
                    Console.Write($"Enter valid choice  (Y/N): ");
                    temp = char.TryParse(Console.ReadLine(), out isContinue);
                }
            }
        }
    }
}