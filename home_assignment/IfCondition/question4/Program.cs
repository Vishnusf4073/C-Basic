using System;
namespace question2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the Second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        if (num1>num2 & num1>num3)
        {
            Console.WriteLine("The 1st Number is the greatest among three");
        }
        if (num2>num1 & num2>num3)
        {
            Console.WriteLine("The 2nd Number is the greatest among three");
        }
        if (num3>num1 & num3>num2)
        {
            Console.WriteLine("The 3rd Number is the greatest among three");
        }
    }
}