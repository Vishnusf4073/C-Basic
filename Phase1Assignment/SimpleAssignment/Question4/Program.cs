using System;
namespace Question3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the INR: ");
        double r =Convert.ToDouble(Console.ReadLine());
        Console.Write("\n USD :"+usd(r));
        Console.Write("\n EUR :"+eur(r));
        Console.Write("\n CNY :"+cny(r));
        
        double usd(double num)
        {
            double a= r/81.9672131147541;
            return a;
        }
         double eur(double num)
        {
            double a= r/78.74015748031496;
            return a;
        }
           double cny(double num)
        {
            double a= r/11.37656427758817;
            return a;
        }
        
    }
}


