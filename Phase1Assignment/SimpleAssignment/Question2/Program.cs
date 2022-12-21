using System;
namespace Question1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the Radius: ");
        double r =Convert.ToDouble(Console.ReadLine());
        Console.Write("Are of Circle is:"+area(r));
        Console.Write("\nPerimeter of Circle is:"+perimeter(r));
        double area(double num)
        {
            double a=num*(3.14)*num;
            return a;
        }
         double perimeter(double num)
        {
            double p=3.14*2*r;
            return p;
        }

    }
}