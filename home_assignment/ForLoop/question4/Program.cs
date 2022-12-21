using System;
namespace ForLoop1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the number (Table to be calculated) : ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i=1;i<=10;i++)
        {
            Console.WriteLine($"\n{num}*{i}="+num*i);   
        }
    }
}