using System;
namespace UnderstandingArraysQ2;
class Program{
    public static void Main(string[] args)
    {
        int size=10,temp;
        int[] array = new int[size];
        Console.WriteLine($"Enter 10 array elements ");
        //getting inputs
        for(int i=0;i<size;i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }     
        //sorting array   
        for(int i=0;i<size-1;i++)
        {
            for(int j=0;j<size-i-1;j++)
            {
                if(array[j]> array[j+1])
                {
                    temp=array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
        //displaying even numbers in ascending order
        Console.WriteLine($"Even numbers in ascending order :");
        for(int i=0;i<size;i++)
        {
            if(array[i]%2==0)
            Console.WriteLine(array[i]);
        }  
        //displaying odd numbers in descending order
         Console.WriteLine($"Odd numbers in descending order :");
        for(int i=size-1;i>=0;i--)
        {
            if(array[i]%2!=0)
            Console.WriteLine(array[i]);
        }  

    }
}