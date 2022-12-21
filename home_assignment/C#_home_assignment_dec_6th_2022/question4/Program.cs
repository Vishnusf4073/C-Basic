using System;
namespace question4
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Radius = ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height = ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume = "+(3.14*r*r*h));
        }
    }
}