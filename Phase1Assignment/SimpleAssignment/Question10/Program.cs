using System;
namespace Qestion6;
class Programs
{
    static void Main(string[] args )
    {
        Console.Write("Enter the number: ");
        char str=Convert.ToChar( Console.ReadLine());
       
        if (str =='a'|| str =='e' || str =='i' || str =='o' || str =='u')
        {
            Console.WriteLine("It is  a vowel\n");
        }
        else
        {
            Console.WriteLine("It is not a vowel\n");
        }
       
    }
}