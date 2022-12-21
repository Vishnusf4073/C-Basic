using System;
namespace question1
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter the celsius: ");
            int cel= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvim = "+(cel+273.15));
            Console.WriteLine("Fahrenheit = "+((cel * 9/5) + 32));
        }
    }
}