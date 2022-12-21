using System;
namespace switch_assignment;
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Enter your Input: ");
            char option;
            bool temp = char.TryParse(Console.ReadLine(),out option);

            switch(option)
            {
                case 'E':
                {
                    Console.WriteLine("Excellent ");
                    break;
                }
                case 'V' :
                {
                    Console.WriteLine("Very Good");
                    break;
                }
                case 'G' :
                {
                    Console.WriteLine("Good");
                    break;
                }
                case 'A' :
                {
                    Console.WriteLine("Average");
                    break;
                }
                case 'F':
                {
                    Console.WriteLine("Fail");
                    break;
                }
            }   
        }
    }