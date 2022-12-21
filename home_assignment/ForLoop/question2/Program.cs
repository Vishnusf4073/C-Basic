using System;
namespace ForLoop1;
class Program
{
    public static void Main(string[] args)
    {
        int res=0;
        int num;
        
        for (int i=1;i<=5;i++)
        {
            Console.WriteLine($"Enter the {i} number ");
            num = Convert.ToInt32(Console.ReadLine());
            res+=num;
            
        }
        Console.WriteLine("sum = "+res);
        double p=res/10;
         Console.WriteLine("percentage ="+p);
    }
}