using System;
namespace TypeConversion;

    class Program
    {
        public static void Main(string[] args)
        {
            //user inputs
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");            
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  mark of subject1: ");
            int mark1 = int.Parse(Console.ReadLine());
            Console.Write("Enter  mark of subject2: ");
            int mark2 = int.Parse(Console.ReadLine());
            Console.Write("Enter  mark of subject3: ");
            int mark3 = int.Parse(Console.ReadLine());
            Console.Write("Enter grade: ");
            char grade = char.Parse(Console.ReadLine());
            Console.Write("Enter mobile number: ");
            long mobileNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter mail id: ");
            string mailId = Console.ReadLine();
            //Printing
            Console.WriteLine("---------------------\n");
            Console.WriteLine("Trainee Details Are: ");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Mobile: {mobileNumber}");
            Console.WriteLine($"Marks1: {mark1} \nMarks2: {mark2} \nMarks3: {mark3}");
            int total = mark1+mark2+mark3;
            Console.WriteLine($"Total: {total}");
            double average = (double)total/3;
            average = Math.Round(average,1);
            string temp = Convert.ToString(average);
            Console.WriteLine(string.Format("{0}",temp));
            Console.WriteLine("Average: "+average);
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Mail id: {mailId}");
        }
    }
