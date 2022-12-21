using System;
namespace question2;
class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Enter the Season Name: ");
        string name = Console.ReadLine().ToLower;

        if (name == "December"|| name == "January" || name == "February")
        {
            Console.WriteLine("Winter");
        }
        if (name == "may"|| name == "April" || name == "March")
        {
            Console.WriteLine("Spring");
        }
        if (name == "june"|| name == "july" || name == "August")
        {
            Console.WriteLine("Summer");
        }
        if (name == "September"|| name == "october" || name == "November")
        {
            Console.WriteLine("Rainy");
        }
    }
}