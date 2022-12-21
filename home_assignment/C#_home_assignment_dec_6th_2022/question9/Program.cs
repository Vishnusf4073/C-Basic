using System;
namespace question9
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Input Speed = ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("time = ");
            int t = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("Distance = "+(s*t)*5/18);
        }

    }
}
