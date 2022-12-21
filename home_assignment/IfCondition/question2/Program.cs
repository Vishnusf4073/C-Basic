using System;
namespace question2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age>=18)
        {
            Console.WriteLine("Congratulation! \n You are eligible for casting your vote.");
        }
        
    }
}