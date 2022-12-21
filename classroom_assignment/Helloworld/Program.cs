using System;
namespace Helloworld;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string my_name = Console.ReadLine();
            
            string father_name = Console.ReadLine();

            Console.WriteLine("My name is : "+my_name+"my father name is : "+father_name);
            Console.WriteLine("my name is {0} my father name is {1}",my_name,father_name );
            Console.WriteLine($"my name is {my_name} my father name is {father_name} ");
        }

    }
