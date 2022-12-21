using System;
namespace DoWhile;
class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter Number: ");
        bool res = int.TryParse(Console.ReadLine(),out num);
         do
    {
       Console.WriteLine("Enter A Correct input :");
       res = int.TryParse(Console.ReadLine(),out num);

       if(num>10)
       {
            Console.WriteLine("Enter correct  Number: ");
            res = int.TryParse(Console.ReadLine(),out num);
       }
    }
    while(num<=10 && res==false);
    Console.WriteLine("output = "+ num);
    }
}
