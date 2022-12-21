using System;
namespace ArrayAssignment;
class Program
{
    public static void Main (string[] args)
    {
        int[] arr = new int[10];
      
        Console.WriteLine($"Element in array are : ");
        for (int i=0; i<10;i++)
        {
            Console.WriteLine($"Enter the {i+1} name: ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        for (int i=0; i<10;i++)
        {
            Console.Write(arr[i]+" ");
            //Console.WriteLine();
        }
        
       
            
        
    }
}