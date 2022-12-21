using System;
namespace ForLoop1;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        Console.WriteLine("Input number of terms : ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write("The odd numbers are :"); 
        for (int i=1;i<=num;i++)
        {
            Console.Write(i+" ");  
            sum+=i;
            i++;
        }
        Console.WriteLine($"\nThe sum of  odd numbers upto{num} is :"+sum+"\n");  

    }
}