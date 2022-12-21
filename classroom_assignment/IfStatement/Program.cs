using System;
namespace if_condition;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());
        if (marks > 80 )
        {
            Console.WriteLine("Grade A");
        }
        if (marks > 60 & marks <=80)
        {
            Console.WriteLine("Grade B");
        }
        if (marks > 35 & marks <=60)
        {
            Console.WriteLine("Grade C");
        }
        if (marks <=35  )
        {
            Console.WriteLine("Grade D");
        }
        else if (marks >100)
        {
            Console.WriteLine("-----Invaild input---- please enter vaild input");
        }
        

    }

}