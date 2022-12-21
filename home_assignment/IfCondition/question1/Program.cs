using System;
namespace question1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num%2==0)
        {
            Console.WriteLine($"{num} is a Even Number");
        }
        else 
        {
            Console.WriteLine($"{num} is an odd Number");
        }
    }
}