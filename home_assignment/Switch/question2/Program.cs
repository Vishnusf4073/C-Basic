using System;
namespace switch_assignment;
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Enter your Input: ");
            int option = Convert.ToInt32(Console.ReadLine());
            

            switch(option)
            {
                case 0:
                {
                    Console.WriteLine("Sunday ");
                    break;
                }
                case 1 :
                {
                    Console.WriteLine("Monday");
                    break;
                }
                case 2 :
                {
                    Console.WriteLine("Tuesday");
                    break;
                }
                case 3 :
                {
                    Console.WriteLine("Wednesday");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Thursday");
                    break;
                }case 5:
                {
                    Console.WriteLine("Friday");
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Saturday");
                    break;
                }
            }   
        }
    }