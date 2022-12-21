using System;
namespace Qestion6;
class Programs
{
    static void Main(string[] args )
    {
        Console.WriteLine("Enter the password: ");
        string str1=Console.ReadLine();
        if (str1=="s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("\nWelcome!\n");
        }
        else{
             Console.WriteLine("\nWrong password\n");
        }
    }
}