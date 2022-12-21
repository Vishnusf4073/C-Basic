using System;
namespace question5
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = "+((a*a)+(b*b)+(2*a*b)));
            
        }

    }
}
