using System;
namespace ArrayAssignment;
class Program
{
    public static void Main (string[] args)
    {
        Console.Write($"Enter the Size of array: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        
        
        for (int i=0; i<n;i++)
        {
            Console.Write($"Enter the {i+1} name: ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.Write($"\nElement in array are : ");
        for (int i=0; i<n;i++)
        {
            Console.Write(arr[i]+" ");
            //Console.WriteLine();
        }
        Console.Write($"\nElement in array are : ");
        for (int i=n-1; i>=0;i--)
        {
            Console.Write(arr[i]+" ");
            //Console.WriteLine();
        }
            
        
    }
}