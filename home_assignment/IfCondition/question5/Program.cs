using System;
namespace question2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("maths: ");
        int sub1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Physics ");
        int sub2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("chemistry: ");
        int sub3 = Convert.ToInt32(Console.ReadLine());

        int percentage = (sub1+sub2+sub3)*100/300;
        Console.WriteLine(percentage);
        if (percentage>=75)
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }
        
    }
}