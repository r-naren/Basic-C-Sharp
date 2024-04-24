using System;
namespace If;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your mark : ");
            float mark = float.Parse(Console.ReadLine());
            if(mark <= 100 && mark > 80){
                Console.WriteLine("Grade A");
            }
            else if(mark < 81 && mark > 60){
                Console.WriteLine("Grade B");
            }
            else if(mark < 61 && mark >= 36){
                Console.WriteLine("Grade C");
            }
            else if(mark >=0 && mark < 36){
                Console.WriteLine("Grade D");   
            }
            else{
                Console.WriteLine("Invalid Input");
            }
            
        }
    }
