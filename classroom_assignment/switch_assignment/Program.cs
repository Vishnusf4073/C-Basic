using System;
namespace switch_assignment;
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Enter the first Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Secong  Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1)addtion :+ \n 2)subtration :-\n 3)Multiplication:*\n 4)Division:/ \n 5)modulo:%");
            Console.WriteLine("Enter your Choice: ");
            char option;
            bool temp = char.TryParse(Console.ReadLine(),out option);

            switch(option)
            {
                case '+':
                {
                    Console.WriteLine("the sum : "+(num1+num2));
                    break;
                }
                case '-' :
                {
                    Console.WriteLine("the sub : "+(num1-num2));
                    break;
                }
                case '*' :
                {
                    Console.WriteLine("the Mul : "+(num1*num2));
                    break;
                }
                case '/' :
                {
                    Console.WriteLine("the Div : "+(num1/num2));
                    break;
                }
                case '%':
                {
                    Console.WriteLine("the mod : "+(num1%num2));
                    break;
                }
                default:
                {
                    Console.WriteLine("sdfgh");
                    break;
                }

            }

          
            
            
        }
    }