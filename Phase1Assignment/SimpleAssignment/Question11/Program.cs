using System;
namespace Question11;
class Program
{
    static void Main(string[] args)
    {
        double s=1;
        Console.Write("enter the X value : ");
        double x=Convert.ToDouble(Console.ReadLine());

        Console.Write("enter the y value : ");
        double y=Convert.ToDouble(Console.ReadLine());
        for (int i =0; i<y; i++)
        {
            s*=x;
        }
        Console.Write(s);
    }
}