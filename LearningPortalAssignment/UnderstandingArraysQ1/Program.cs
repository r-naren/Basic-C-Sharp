using System;
namespace UnderstandingArraysQ1;
class Program{
    public static void Main(string[] args)
    {
        int size=5,temp;
        int[] array = new int[size];
        Console.WriteLine($"Enter 5 array elements ");
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
        //displaying sorted array
        Console.WriteLine($"Ascending order :");
        
        for(int i=0;i<size;i++)
        {
            Console.WriteLine(array[i]);
            
        }  

    }
}