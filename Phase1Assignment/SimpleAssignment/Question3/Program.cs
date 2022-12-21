using System;
namespace Question3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the celsius: ");
        double c =Convert.ToDouble(Console.ReadLine());
        Console.Write("degrees on Fahrenheit scale (°F):"+converts(c));
        
        double converts(double num)
        {
            double a= c*(9/5)+32;
            return a;
        }
    }
}