using System;
namespace question2;
class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Enter the Season Name: ");
        string name = Console.ReadLine();
        name=name.ToLower();
        if (name == "december"|| name == "january" || name == "february")
        {
            Console.WriteLine("Winter");
        }
        if (name == "may"|| name == "april" || name == "march")
        {
            Console.WriteLine("Spring");
        }
        if (name == "june"|| name == "july" || name == "august")
        {
            Console.WriteLine("Summer");
        }
        if (name == "september"|| name == "october" || name == "november")
        {
            Console.WriteLine("Rainy");
        }
 
    }
}