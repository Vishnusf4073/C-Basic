using System;
namespace DoWhile;
class Program
{
    static void Main(string[] args)
    {
        string condition;
        do{
            Console.WriteLine("Enter the number you want to check");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("The Given Number is even: ");
            }
            else
            {
               Console.WriteLine("The Given Number is an odd"); 
            }
            Console.WriteLine("Do you want to check with another number?");
            condition=Console.ReadLine();
            while(condition !="yes" && condition!="no")
            {
                Console.WriteLine("Invaild input Please Enter the vaild input\n");
                condition=Console.ReadLine().ToLower();
            }
       
        }while(condition=="yes");
        
    }
}