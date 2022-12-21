using System;
namespace question2;
class Program
{
    static void Main(string[] args)
    {
        
        string password = "HiTeam";
        Console.WriteLine("Enter the Password: ");
        string Input = Console.ReadLine();
        
        if (Input == password)
        {
            Console.WriteLine("Right Password");
        }
       else
        {
            Console.WriteLine("Worng Password");
        }
        
 
    }
}