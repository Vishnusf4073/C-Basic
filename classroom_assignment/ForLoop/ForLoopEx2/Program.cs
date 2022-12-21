using System;
namespace ForLoop1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the limt number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i=1;i<=num;i++)
        {
            Console.WriteLine(i*i);
        }
    }
}