using System;
namespace question2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input: ");
        int sugar_level = Convert.ToInt32(Console.ReadLine());

        if (sugar_level <90)
        {
            Console.WriteLine("lower Sugar level");
        }
        if (sugar_level>=90 & sugar_level<130)
        {
            Console.WriteLine("Normal sugar level ");
        }
        if (sugar_level >=130 & sugar_level <140)
        {
            Console.WriteLine("Medium sugar level");
        }
        if (sugar_level >=140 & sugar_level <170)
        {
            Console.WriteLine("high sugar ");
        }
        if (sugar_level >=170 )
        {
            Console.WriteLine("you are very high sugar level ");
        }
       
    }
}