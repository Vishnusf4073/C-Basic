using System;
namespace Qestion6;
class Programs
{
    static void Main(string[] args )
    {
        Console.Write("Enter the number: ");
        int num= Convert.ToInt32(Console.ReadLine());
        if (num<=10)
        {
            Console.WriteLine("Slow");
        }
        else if(num>10 & num<=50)
        {
            Console.WriteLine("average");
        }
         else if(num>50 & num<=150)
        {
            Console.WriteLine("fast");
        }
         else if(num>15 & num<=1000)
        {
            Console.WriteLine("Ultra fast");
        }
        else if (num>1000)
        {
             Console.WriteLine("Extremely fast\n");
        }
    }
}