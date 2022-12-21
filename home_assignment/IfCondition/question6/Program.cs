using System;
namespace question2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the temperature: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        
        if (temp<0)
        {
            Console.WriteLine("Freezing weather ");
        }
        if (temp>=0 & temp<10)
        {
            Console.WriteLine(" Very Cold weather");
        }
        if (temp>=10 & temp<20)
        {
            Console.WriteLine(" Cold weather");
        }
        if (temp>=20 & temp<30)
        {
            Console.WriteLine(" Cold weather");
        }
        if (temp>=30 & temp<40)
        {
            Console.WriteLine("Normal in temperature");
        }
        if (temp>=40)
        {
            Console.WriteLine("very Hot");
        }
    }
}