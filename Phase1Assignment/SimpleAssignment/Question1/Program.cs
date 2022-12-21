using System;
namespace Question1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        Console.Write($"{num} Cms = {num*2.54} Inches");
    }
}