using System;
namespace Question13;
class Program 
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num= Convert.ToInt32(Console.ReadLine());

        for (int i=1; i<=20; i++)
        {
            Console.Write($"{num}*{i}={num*i} \n");
        }
    }
}