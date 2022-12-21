using System;
namespace DoWhile;
class Program
{
    static void Main(string[] args)
    {
        string condition;
        int res=0;
        do{
            Console.WriteLine("Enter the number :");
            int num=Convert.ToInt32(Console.ReadLine());
            res += num; 
            Console.WriteLine("sun = "+res);
            Console.WriteLine("Do you want to add another number?(yes/no)");
            condition=Console.ReadLine();

            while(condition !="yes" && condition!="no")
            {
                Console.WriteLine("Invaild input Please Enter the vaild input\n");
                condition=Console.ReadLine().ToLower();
            }
       
        }while(condition=="yes");
        
    }
}