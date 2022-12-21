using System;
namespace Qestion6;
class Programs
{
    static void Main(string[] args )
    {
        Console.WriteLine("Enter the number: ");
        int num= Convert.ToInt32(Console.ReadLine());
        if (num<100)
        {
            Console.WriteLine("\nLess than 100");
        }
        else if(num>=100 & num<200)
        {
            Console.WriteLine("\nBetween 100 and 200");
        }
        else{
             Console.WriteLine("\nGreater than 200\n");
        }
    }
}