using System;
namespace WhileLoop2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the limit number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int i=0,res=0;
        while(i<=num)
        {
             Console.WriteLine($"Enter the {1}number: ");
             int val = Convert.ToInt32(Console.ReadLine());
             res+=val*val;
             i++;
        }
    }
}