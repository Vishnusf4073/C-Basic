using System;
namespace WhileLoopEx2;
class Program
{
    static void Main(string[] args)
    {
        int i=0;
        while(i<25)
        {
            Console.WriteLine(i);
            i+=2;
        }

        Console.WriteLine("enter the number: ");
        int num;
        bool result = int.TryParse(Console.ReadLine(),out num);
        while(!result)
        {
             Console.WriteLine("Invalid number. Please Enter in the Number Format");
             result = int.TryParse(Console.ReadLine(),out num);

        }
        Console.WriteLine("the number is : "+num);
        

        
    }
}