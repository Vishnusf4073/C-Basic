using System;
namespace question5
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Physics = ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("chemistry = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maths = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = "+(p+c+m));
            Console.WriteLine("Percentage = "+((p+c+m)*100/300));
        }

    }
}
